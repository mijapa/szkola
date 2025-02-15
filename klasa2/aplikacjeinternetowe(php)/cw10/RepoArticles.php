<?php
require_once "Article.php";
require_once "configuration.php";
class RepoArticles{
    public static function getAll(string $dir=DIR):array {
        $result = scandir($dir);
        $articles = [];
        foreach($result as $art){
            if($art!=='.' && $art!=='..'){
                $a = new Article("",$art);
                $a->getContentFromFile($dir.'/'.$art);
                $a->setDate(date("d-m-Y H:i:s",filemtime($dir.'/'.$art)));
                $articles[] = $a;
            }
        }
        return $articles;
    }
    public static function saveArticle(Article & $a):void
    {
        $dir = DIR;
        if(file_exists($dir.'/'.$a->getTitle())) return;
        $plik = fopen($dir.'/'.$a->getTitle(),'w');
        fwrite($plik,$a->getContent());
        fclose($plik);
    }
    public static function getByTitle(string $title):Article{
        $dir = DIR;
        if(file_exists($dir.'/'.$title)){
            $a = new Article($title);
            $a->setDate(date("d-m-Y H:i:s",filemtime($dir.'/'.$title)));
            return $a;
        }else{
            return null;
        }
    }
    public static function deleteArticle(string $fileName):bool
    {
        return unlink(DIR.'/'.$fileName);
    }
}
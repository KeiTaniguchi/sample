#include <stdio.h>
#include <stdlib.h>

//問題集Ｑ１
/*scanf関数を使って整数値を標準入力から1回だけ読み込み、その値をint型変数valに格納し、そのまま表示するプログラムを作成せよ。*/

int main(){

	//int val;
	//printf("整数値を入力してください。\n");
	//scanf("%d" , &val);
	//printf("入力した値は%dです。\n" , val);

	/*これだけじゃつまらないので、復習がてらfgetsでもやってみよう。*/
	char *val;
	val = (char *)malloc(sizeof(val) * 256);
	printf("文字を入力してください。\n");
	fgets(val , sizeof(val) , stdin);
	printf("入力した文字は%sです。\n" , val);

	free(val);

	return 0;
}

/*感想*/
/*
scanf関数は業務ではタブーと聞いている。
今までの経験上fgetsを使用するのがよさそうだが、ひとまず練習問題ということでやってみた。
でもこんなんじゃ簡単すぎるなぁ・・。今後この問題集だけでなく、もう少し課題的な問題を
やってみよう。
*/


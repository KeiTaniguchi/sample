#include <stdio.h>
#include <stdlib.h>

//���W�p�P
/*scanf�֐����g���Đ����l��W�����͂���1�񂾂��ǂݍ��݁A���̒l��int�^�ϐ�val�Ɋi�[���A���̂܂ܕ\������v���O�������쐬����B*/

int main(){

	//int val;
	//printf("�����l����͂��Ă��������B\n");
	//scanf("%d" , &val);
	//printf("���͂����l��%d�ł��B\n" , val);

	/*���ꂾ������܂�Ȃ��̂ŁA���K���Ă�fgets�ł�����Ă݂悤�B*/
	char *val;
	val = (char *)malloc(sizeof(val) * 256);
	printf("��������͂��Ă��������B\n");
	fgets(val , sizeof(val) , stdin);
	printf("���͂���������%s�ł��B\n" , val);

	free(val);

	return 0;
}

/*���z*/
/*
scanf�֐��͋Ɩ��ł̓^�u�[�ƕ����Ă���B
���܂ł̌o����fgets���g�p����̂��悳���������A�ЂƂ܂����K���Ƃ������Ƃł���Ă݂��B
�ł�����Ȃ񂶂�ȒP������Ȃ��E�E�B���ケ�̖��W�����łȂ��A���������ۑ�I�Ȗ���
����Ă݂悤�B
*/


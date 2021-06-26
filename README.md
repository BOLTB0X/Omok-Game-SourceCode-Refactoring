오목게임 소스코드 리팩토링

기존 불필요한 서버자원 낭비하는 문제점 현재 접속한 플레이어 (Client) 를 저장하는 connections 리스트에서 포인터 원소를 사용하지 않음

그러므로 한 명의 플레이어 (Client) 정보는 한 번 선언되면 반복적으로 선언하지 않도록 해야 함 

Alpha Beta Pruning 인공지능 알고리즘 적용



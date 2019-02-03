const gpio=require('rpi-gpio');
const record=require('node-record-lpcm16');
const aikit=require('./aimakerskitutil');
const req = require('request');

const http = require('http');

//PCM 사운드 출력을 위한 모듈 설정
const Speaker=require('speaker');
const fs=require('fs');
//Sample Sound 데이터 로드
const soundBuffer=fs.readFileSync('../data/sample_sound.wav');
const pcmplay=new Speaker({
	channels:1,
	bitDepth:16,
	sampleRate:16000
});

//GPIO 설정
gpio.setup(29,gpio.DIR_IN,gpio.EDGE_BOTH);//버튼 핀은 입력으로
gpio.setup(31,gpio.DIR_LOW,write);//LED 는 출력으로 설정
//GPIO Output에 대한 오류를 전달하는 콜백
 
const Gpio = require("onoff").Gpio;
const led = new Gpio(17,"out");

let ledVal = 0;



function write(err){
	if(err) console.log('write Error:'+err);
};

const client_id='Y2xpZW50X2lkMTU0NTM4MzA4NzE5Nw==';
const client_key='Y2xpZW50X2tleTE1NDUzODMwODcxOTc=';
const client_secret='Y2xpZW50X3NlY3JldDE1NDUzODMwODcxOTc=';
const json_path='/home/pi/Downloads/clientKey.json';
const cert_path='../data/ca-bundle.pem';
const proto_path='../data/gigagenieRPC.proto';

let pcm=null;

aikit.initializeJson(json_path,cert_path,proto_path);

let sysStat=0;//0:버튼이 눌려지고 서비스를 제공할 준비가 되어 있음, 1: 서비스를 제공중임

//GPIO에서 변화를 Detect 함
gpio.on('change',(channel,value)=>{
	//29번 핀에 변화가 있는 경우
	if(channel===29){
		console.log('Channel:'+channel+' value is '+value);
		//버튼이 눌려졌을 경우
		if(value===false){
			//서비스를 제공할 준비가 되어 있으면
			if(sysStat===0) {
				sysStat=1;
				console.log('Button Pressed. Start Service');
				
				//LED를 켜고
				gpio.write(31,true);
				
				//샘플 사운드를 출력하고
				pcmplay.write(soundBuffer);
				var a = console.log(1);
				let myinterval = setInterval(function(){
					lodVal=led.readSync();
					if(ledVal==0){
						ledVal=1;
					}else{
						ledVal=0;
					}
					led.writeSync(ledVal);
				}, 200);

				setTimeout(function(){
					clearInterval(myinterval);
					led.writeSync(0);
					
					sysStat=0;

				}, 3000);
				
				

				
			} 
		}
	}
});

	
	//$.post("http://travel-plus.co.kr/board/boinsert"),
		//{titleInsert: a,contentInsert: c,nameInsert: b,passwordInsert: d},
	//function(data){console.log("입력완료");



spleeterPlus
====
## 説明
spleeterをVisual Studioアプリでラップしてるだけです。

[Gigazineの記事を見て面白そうだったので。](https://gigazine.net/news/20191107-spleeter/)

```python
  conda activate spleeter-cpu
  spleeter separate -i spleeter/audio_example.mp3 -p spleeter:2stems -o output
```
この辺りのコマンド発行（パラメータ部分含み）をGUIでやらせます。

## 必要なもの。
spleeterがインストールされて動くこと。ちなみに私はMinicondaで動かしてます。

[Condaのインストール周りはこちら。](https://docs.conda.io/en/latest/)

[spleeterのGithubパスはこちら。](https://github.com/deezer/spleeter)

## Usage
フォームが一つ開きますので、最初のテキストボックスには、Anacondaのインストールパスを入れましょう。
あとは見れば分かるかと。

実行ボタンを押すとPowerShellのウィンドウに進捗状況もろとも表示されます。
標準出力の内容までアプリに取り込まなかったのです。

ソースまるごとあるので、お好きに改造してください。

## 作者
[dhamaoka](https://github.com/dhamaoka)

## 今後の予定
気が向いたら、ドラッグ＆ドロップ対応とか、出力後のWaveファイルをMP3に変換するとか対応するかも知れません。

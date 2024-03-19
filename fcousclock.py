import time

def focus_timer(minutes):
    seconds = minutes * 60
    while seconds > 0:
        print(f"倒计时：{seconds}秒")
        time.sleep(1)
        seconds -= 1
    print("时间到！专注结束。")

if __name__ == "__main__":
    minutes = int(input("请输入专注时长（分钟）："))
    focus_timer(minutes)

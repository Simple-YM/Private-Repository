#include <iostream>
#include <string>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/highgui.hpp>

using namespace std;

int main() {
    // 图像路径
    const string fileName = "xxx.jpg";
    
    // 读取图像
    cv::Mat origin = cv::imread(fileName);
    
    // 创建结果图像变量
    cv::Mat result;
    
    // 设置高斯双边滤波参数
    const int d = 10；
    const float sigmaColor = 40；
    const float sigmaSpace = 40；
    
    // 高斯双边滤波
    cv::bilateralFilter(origin,
                        result,
                        d,
                        sigmaColor,
                        sigmaSpace);

    // 对比效果
    cv::imshow("Origin Image", origin);
    cv::imshow("Result", result);
    
    cv::waitKey(0);
}

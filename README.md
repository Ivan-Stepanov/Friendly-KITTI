
![alt text](https://github.com/Ivan-Stepanov/Friendly-KITTI/blob/master/Friendly-KITTI%20Screenshot.jpg)
# Friendly KITTI
A user-friendly bounding box labeling tool for creation of KITTI data-sets used to train neural networks in NVIDIA DIGITS

This tool allows a very quick drawing of bounding boxes around objects in images and saving the labeling information in .txt files in the KITTI format which can be directly used to train DetectNet neural networks in NVIDIA DIGITS:

https://github.com/NVIDIA/DIGITS

https://developer.nvidia.com/digits

It also allows you to multiply your labeled data-set by mirroring and rotating the images.

# Installation:
No installation is reqiered. Just download the "Release/Friendly KITTI.exe" and execute. If you want to have the Help-File included (contains the same information as this README.md), download the whole folder "Release".
If you want to make changes and compile the project youself, download the repository and open the C# project. Works with VS 2017 Community Edition.

# Usage:
1.	Select the folder with your unlabeled images
2.	Select the folder where your labeled images and label.txt files will be saved (subfolders "images" and "labels" will be created automatically). If this folder already contains labeled images, the label-files will be read and bounding boxes can be adjusted and corrections can be saved.
3.  Label your images or modify existing label files:
    - prepare your object classes by creating new object classes (bottom left) and choosing class name and bounding box color
    - select an object class by clicking on a bullet button or pressing keys 1-9
    - draw bounding boxes on your image and eventually adjust them using the handles
    - if you want to delete the last drawn bounding box press "d" or click "delete" button in the tool-bar. If you want to delete an arbitrary bounding box, click on its handle and the press "d" or click "delete". The truncation value can be entered in the text-box on the tool-bar or a coarse value can be chosen in the drop-down menu
    - save all displayed bounding boxes and load next image by pressing the "SPACE" bar OR by using the mouse wheel OR by using the drop-down list on the tool bar OR by clicking "Next" / "Previous" button on the tool-bar. If you just want to display bounding boxes of labeled images without saving them when the next image is loaded, you can click on the left-most button on the tool-bar and change the status "Saving"/"Not Saving"
    - a very quick labeling scenario would look like this: left hand is on the keyboard, right hand is on the mouse. Press "1" for object"car", draw a bounding box, press "2" for "pedestrian", draw bounding box, press "SPACE" to save changes and load next image, repeat. In academic projects with large data-sets, it is advised to use an undergraduate slave for this task :)
4.	After you are done labeling your files click the „/train /val“ button. Select the final folder which will contain the "train" and "val" subfolders and will later be used in NVIDIA DIGITS (subfolders will be created automatically). Chose if you want to multiply your dataset by mirroring and rotation (up to 8-fold multiplication). Click OK. The files will be copied from the "labeled"-folder and you can observe the progress in the bottom-left status bar.

# Known issues:
Scaling Problems, buttons and controls have wrong sizes and positions
Solution: right-click the exe-file, select "Properties", go to „Compatibility“ and uncheck „Disable display scaling on high DPI displays“

If you find more problems or you have some suggestions, please use the issues section.

# For more information
Download NVIDIA DIGITS:

https://developer.nvidia.com/digits

Information on the KITTI data-set format:

https://github.com/NVIDIA/DIGITS/blob/master/digits/extensions/data/objectDetection/README.md

Information on how to use DetectNet:

https://github.com/NVIDIA/DIGITS/tree/master/examples/object-detection

A large labeled KITTI data-set (over 6000 images, 12GB) from the Karlsruhe Institute of Technology:

http://www.cvlibs.net/datasets/kitti/eval_object.php

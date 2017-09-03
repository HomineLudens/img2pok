## img2pok
img2pok is a small utility for convert images to an C compatible format for [POKITTO](http://www.pokitto.com/)  

![img2pok](https://github.com/Effer/img2pok/blob/master/Docs/V0.4.jpg)

Original inspired to [bmp2pok](https://github.com/pokitto/bmp2pok) it allows to read a wider range of images format.  
Features:  
* Load images in common formats (*.jpg,*.bmp,*.png,*.tiff)
* Use image as palette (extract all colors from palette)
* Extract palette from image (experimental, using simple color distance)
* Editable palette (add/remove/edit colors, drag and drop to change order)
* Split image in multiple tiles

Developed in C# using WinForm works in Windows and Linux too (using mono)  
  
**Windows:**  
Double click on executable  
Require .NET 4.5.2 (usually already installed)  


**Linux:**  
`sudo apt-get install mono-runtime`  
`sudo apt-get install libmono-system-windows-forms4.0-cil`

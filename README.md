# Unity_Attributes
 
* ### **ReadOnlyAttribute**

Example:
```C#
[ReadOnly]
public string field = "Test string";
```
_Original_ <br/>
![Original](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/Field%20Original.jpg) <br/>
_With Attribute_ <br/>
![With Attribute](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/Field%20Attribute%20(ReadOnly).jpg) <br/>
<br/>

* ### **HeaderBoxAttribute**

Example:
```C#
// You can also add "spaceBefore" and "spaceAfter". Default values are 0.
[HeaderBox("Header Box")]
public int num;
```
![](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/HeaderBox%20Attribute.jpg) <br/>
<br/>

* ### **ArrayAsPopUpAttribute**

Example:
```C#
[ArrayAsPopup(new string[] { "Warrior", "Mage", "Ranger", "Druid" })]
public int defaultPopUp;
[ArrayAsPopup(new string[] { "Warrior", "Mage", "Ranger", "Druid" }, hasLabel: false)]
public int noLabel;
[ArrayAsPopup(new string[] { "Warrior", "Mage", "Ranger", "Druid" }, labelWidth: 35)]
public int smallLabel;
[ArrayAsPopup(new string[] { "Warrior", "Mage", "Ranger", "Druid" }, displayName: "Changed Label")]
public int thisLabelIsGoingToBeChanged;
```
![](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/ArrayAsPopUp%20Attribute.jpg) <br/>
<br/>

* ### **SliderBarAttribute**

Example:
```C#
[SliderBar(0, 100, 255, 0, 0)]
public int defaultBar;
[SliderBar(0, 100, 0, 0, 255, hasLabel: false)]
public int noLabel;
[SliderBar(0, 100, 255, 255, 0, labelWidth: 35)]
public int smallLabel;
[SliderBar(0, 100, 0, 255, 0, displayName: "Changed Label")]
public float thisLabelIsGoingToBeChanged;
```
![](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/SliderBar%20Attribute.jpg) <br/>
<br/>

* ### **MatrixPreviewAttribute**

Example:
```C#
[MatrixPreview]
public Matrix4x4 transformMatrix;
```
_Original_ <br/>
![Original](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/Matrix4x4%20Original.jpg) <br/>
_With Attribute_ <br/>
![With Attribute](https://github.com/andreastmedia/Unity_Attributes/blob/main/0%20-%20Images%20-%200/Matrix4x4%20Attribute%20(MatrixPreview).jpg) <br/>

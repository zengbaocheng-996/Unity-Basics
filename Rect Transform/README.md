# Rect Transform

The Rect Transform component is the 2D layout counterpart of the Transform component. Where Transform represents a single point, Rect Transform represent a rectangle that a UI element can be placed inside. If the parent of a Rect Transform is also a Rect Transform, the child Rect Transform can also specify how it should be positioned and sized relative to the parent rectangle.

| Property                 | Function                                                     |
| ------------------------ | ------------------------------------------------------------ |
| Pos (X, Y, Z)            | Position of the rectangle's pivot relative to the anchors.   |
| Width/Height             | Width and height of the rectangle.                           |
| Left, Top, Right, Bottom | Positions of the rectangle's edges relative to their anchors. This can be thought of as padding inside the rectangle defined by the anchors. Shown in place of Pos and Width/Height when the anchors are separated. |
| Anchors                  | The anchor points for the lower left corner and the upper right corner of the rectangle. |
| Min                      | The anchor point for the lower left corner of the rectangle defined as a fraction of the size of the parent rectangle. 0,0 corresponds to anchoring to the lower left corner of the parent, while 1,1 corresponds to anchoring to the upper right corner of the parent. |
| Max                      | The anchor point for the upper right corner of the rectangle defined as a fraction of the size of the parent rectangle. 0,0 corresponds to anchoring to the lower left corner of the parent, while 1,1 corresponds to anchoring to the upper right corner of the parent. |
| Pivot                    | Location of the pivot point around which the rectangle rotates, defined as a fraction of the size of the rectangle itself. 0,0 corresponds to the lower left corner while 1,1 corresponds to the upper right corner. |
| Rotation                 | Angle of rotation (in degrees) of the object around its pivot point along the X, Y and Z axis. |
| Scale                    | Scale factor applied to the object in the X, Y and Z dimensions. |

|                    |                                                              |
| ------------------ | ------------------------------------------------------------ |
| anchoredPosition   | The position of the pivot of this RectTransform relative to the anchor reference point. |
| anchoredPosition3D | The 3D position of the pivot of this RectTransform relative to the anchor reference point. |
| anchorMax          | The normalized position in the parent RectTransform that the upper right corner is anchored to. |
| anchorMin          | The normalized position in the parent RectTransform that the lower left corner is anchored to. |
| offsetMax          | The offset of the upper right corner of the rectangle relative to the upper right anchor |
| offsetMin          | The offset of the lower left corner of the rectangle relative to the lower left anchor |
| pivot              | The normalized position in this RectTransform that it rotates around |
| rect               | The calculated rectangle in the local space of the Transform |
| sizeDelta          | The size of the RectTransform relative to the distances between the anchors |


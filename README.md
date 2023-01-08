# Humanoid Soccer Robot
During last few years, humanoid robots are developing surprisingly to reach the dream of the
international robotics committee to have a match between humans and a team of robots.
</br>
From 2012 to 2016, the Team Parand gradually developed this project as it's base source code in the RoboCup competitions. This team
was successful enough to gain several honors in international and world championships.
 </br></br>
 
 ## Developers
| Name                                                | Email                                                     | Website                              |
| -------------                                       | -------------                                             | -------------                        |
| [Ahmad Amirivojdan](https://github.com/amirivojdan) | [aamirivo@vols.utk.edu](mailto:aamirivo@vols.utk.edu)     | [amirivojdan.io](http://www.amirivojdan.io)   |
| [Farzad Nadiri](https://github.com/farzadnadiri)    | [farzadnadiri7@gmail.com](mailto:farzadnadiri7@gmail.com) | [nadiri.io](http://www.nadiri.io) |
</br>

![wqqq3e](https://user-images.githubusercontent.com/6237268/158467668-2b5b3fe9-ddc3-4cd9-8a8f-0246c6ecec2f.jpg)


https://user-images.githubusercontent.com/6237268/158478738-22409dc2-c38a-443d-8f18-19c8ec5f6e67.mp4



## Vision and Head control Module
Using this module, the robot is able to get information about its surroundings, its location on the field, and to detect where the ball and the goal are. To implement accurate ball and goal detection, objects in the field are sampled and gathered in a color table, and then algorithms such as hough line detection and circle detection are utilized.
EmguCV (a cross-platform .Net wrapper to OpenCV image processing library) is used in this module to capture and process images at a rate of approximately 29 frames per second.
HSV colour space is used rather than RGB colour space, “because the R, G, and B components of an object’s color in a digital image are all correlated with the amount of light hitting the object, and therefore with each other, image descriptions in terms of those components make object discrimination difficult. 
Furthermore, in this module various algorithms such as PID controllers have been used to control the robot's head to search for the ball and track it.
</br>
</br>
![vision](https://user-images.githubusercontent.com/6237268/158469069-534102eb-db8d-47e9-aa4a-df9265f78ef0.jpg)

## Locomotion and Balance control Module
### Motion Editor
“Static motions enable humanoid robots to solve static problems where a dynamic solution would not provide noteworthy benefits.” Says,“The most popular technique to create static motions for humanoid robots is keyframing. Since a key  frame motion defines many joint angles, tools for the design of key frame motions should support the motion designer to deal with them.” Since former team members were using RoboPlus motion editor to design keyframes,
implementation of a motion editor inspired from Robotis motion editor and aimed to have all functionalities (managing Pages and Steps, On/Off, Mirror, Etc.) that RoboPlus has decided.
The motion editor is used to create predefined motion patterns like Stand Style, Kick, Stand Up, and Block. Further more Bezier curves is used to produce smoother and cosequently more human-like motions in action.

![Capture2](https://user-images.githubusercontent.com/6237268/158459633-888b843f-d9c3-416b-bc16-7e2afb0abc4e.PNG)

### Walk Engine & Stabilization
“Omnidirectional locomotion is a concept that has proven to be advantageous in dynamic environments and in restricted spaces. The ability to move in any direction, irrespective of the orientation of the vehicle, and to control the rotational speed at the same time has advantages in many domains.”
We developed a 4 phase COM shifting omnidirectional walking pattern generation approach. As walking speed is an absolutely crucial feature during the match, the Darwin-OP walk engine has been implemented and used along with the old walk engine in C# code. Fortunately, the walk engine successfully integrated on robot platform. </br>
“Balance control is an important topic for humanoid robotics and is becoming increasingly necessary for humanoid robots that must function within a human-centric environment. Regardless of the quality of bipedal locomotion, a humanoid robot must still be prepared for unexpected perturbations that could throw it off balance. These events are unpredictable and  potentially unavoidable; therefore, it is necessary to have robust controllers for balance maintenance and recovery.”
To improve stability while walking, an initial version of Arm, Hip, and Ankle strategies are implemented and integrated into the walk engine in order to counter unpredictable disturbances and collisions.

![Capture3](https://user-images.githubusercontent.com/6237268/158459649-a77866aa-7b10-4d13-86fa-01e5f27a6e58.PNG)
## Configuration and Monitoring Module
All robot configuration files are created and saved in XML format. This module allows the operator to view and edit these files so that human error is reduced during configuration. Also, the balance and movement of the robot in the relevant forms can be seen on the chart, which helps the debugging operation.
</br>
</br>
![2](https://user-images.githubusercontent.com/6237268/158462108-0ecf67b9-7e59-4f31-97f8-2f29e31cfd63.png)
## Network and Communication Module
Teammate communication is implemented in order to avoid collision while both robots are approaching the ball. This means both robots are aware of their distance from ball and share it via Wi-Fi and when both robots are approaching the ball, the robot that has much more distance from ball, stops and the other one continue his way. If the nearest robot fall down or lose the ball, the other one also continue the game. By using this approach, robots do not disturb each other during the match. Furthermore they also cover each other.
</br>
 Referee orders are also sent on the network and through the referee console on the UDP protocol, which this module receives and processes these orders.
## Behaviour Module
Since this robot must be able to follow the match autonomously a state machine for processing the status and determining the behavior of the robot has been implemented in this module. This helps the robot to select and execute a suitable phase at any time based on the existing conditions. An interface for match settings has been implemented on top of this state machine, so quick adjustments during the match can be made if necessary.
</br></br>
![Capture6](https://user-images.githubusercontent.com/6237268/158462129-3b655375-fea6-44f9-b415-b3dbcad165f8.PNG)
</br></br>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimationplayerExamBites.Classes
{
    public class Initilization
    {
        public Level Initialize(int  lname)
        {
            Level l = null;
            if (lname == 9)
            {
                 l = new Level(9);
                //level.Levelname = 9;
                var subjectPhy = new Subject("Physics",l);
                var subjectChem = new Subject("Chemistry",l);
                var subjectBio = new Subject("Bio",l);
                var subjectMaths = new Subject("Maths",l);

                var chapter1phy = new Chapter(1, "Physical Quantities and Mesurements", @"pack://application:,,,/images/chapter.jpg", subjectPhy); // LEVEL 9 PHYSICS CHAPTER 1 declaration
                var topicAbc = new Topic("What is Physics", 1, "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicDef = new Topic("Physical Quantities", 2, "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicGhi = new Topic("Base Quantities", 3, "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicJkl = new Topic("Derived Units", 4, "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicJkl5 = new Topic("Prefixes", 5, "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicJkl6 = new Topic("Prefixes Continue", 6 , "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicJkl7 = new Topic("Scientific notations", 7 , "pack://application:,,,/images/chapter.jpg", chapter1phy);
                var topicJkl8 = new Topic("Accuracy vs Precision", 8 , "pack://application:,,,/images/chapter.jpg",chapter1phy);
                var topicJkl9 = new Topic("Accuracy vs Precision Audio Story", 9, "pack://application:,,,/images/chapter.jpg", chapter1phy);

                var chapter2phy = new Chapter(2, "Kinematics", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topicAbc2 = new Topic("Types of motion", 1, "pack://application:,,,/images/chapter.jpg", chapter2phy);
                var topicDef2 = new Topic("Scalers and Vectors", 2, "pack://application:,,,/images/chapter.jpg", chapter2phy);
                var topicGhi2 = new Topic("Motion", 3 , "pack://application:,,,/images/chapter.jpg", chapter2phy);
                var topicJkl2 = new Topic("Equation of Motions", 4 , "pack://application:,,,/images/chapter.jpg", chapter2phy);


                var chapter3phy = new Chapter(3, "Dynamics", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topicAbc3 = new Topic("Momentum", 1, "pack://application:,,,/images/chapter.jpg", chapter3phy);
                var topicDef3 = new Topic("Newtons Law of motion", 2, "pack://application:,,,/images/chapter.jpg", chapter3phy);
                var topicGhi3 = new Topic("Law of conservation of Momentum", 3, "pack://application:,,,/images/chapter.jpg", chapter3phy);
                var topicJkl3 = new Topic("Friction", 4, "pack://application:,,,/images/chapter.jpg", chapter3phy);


                var chapter4phy = new Chapter(4, "Turning Effect of Forces", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic4_1 = new Topic("like vs unline forces", 1, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_2 = new Topic("addition of vectors", 2, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_3 = new Topic("resolution of vectors", 3, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_4 = new Topic("Rectangular components example", 4 , "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_5 = new Topic("Forces from components", 5, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_6 = new Topic("Toruqe of moment of force", 6 , "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_7 = new Topic("torque and moment arm", 7 , "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_8 = new Topic("Principle of Moments", 8, "pack://application:,,,/images/chapter.jpg",chapter4phy);
                var topic4_9 = new Topic("Example 4.4", 9, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_10 = new Topic("Center of mass", 10, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_11 = new Topic("Center of Gravity", 11, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_12 = new Topic("couple", 12, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_13 = new Topic("Equlibirum", 13, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_14 = new Topic("1st condition of equilibirum", 14, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_15 = new Topic("Paratropper is in equilibirum", 15, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_16 = new Topic("second conditon of equilibirum", 16, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_17 = new Topic("state of equilibirum 1", 17, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_18 = new Topic("state of equilibirum 2", 18 , "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_19 = new Topic("pendulum ", 19, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_20 = new Topic("unstable equilibirum", 20, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_21 = new Topic("neutral equilibirum", 21, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_22 = new Topic("Stability and Postion of Center of Mass 1", 22, "pack://application:,,,/images/chapter.jpg", chapter4phy);
                var topic4_23 = new Topic("Stability and Postion of Center of Mass 2", 23, "pack://application:,,,/images/chapter.jpg", chapter4phy);

                var chapter5phy = new Chapter(5, "Gravitation", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic5_1 = new Topic("Law of gravitation", 1, "pack://application:,,,/images/chapter.jpg", chapter5phy);
                var topic5_2 = new Topic("Mass of the Earth", 2, "pack://application:,,,/images/chapter.jpg", chapter5phy);
                var topic5_3 = new Topic("Variation of G with Altitude", 3, "pack://application:,,,/images/chapter.jpg", chapter5phy);
                var topic5_4 = new Topic("Artificial Gravity", 4, "pack://application:,,,/images/chapter.jpg", chapter5phy);


                var chapter6phy = new Chapter(6, "Work And Energy", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic6_1 = new Topic("Work", 1, "pack://application:,,,/images/chapter.jpg", chapter6phy);
                var topic6_2 = new Topic("Energy", 2, "pack://application:,,,/images/chapter.jpg", chapter6phy);
                var topic6_3 = new Topic("Kinetic Energy", 3, "pack://application:,,,/images/chapter.jpg", chapter6phy);
                var topic6_4 = new Topic("Potential Energy", 4, "pack://application:,,,/images/chapter.jpg", chapter6phy);


                var chapter7phy = new Chapter(7, "Properties of Matter", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic7_1 = new Topic("Density", 1, "pack://application:,,,/images/chapter.jpg", chapter7phy);
                var topic7_2 = new Topic("Pressure", 2, "pack://application:,,,/images/chapter.jpg", chapter7phy);
                var topic7_3 = new Topic("Atmospheric Pressure", 3, "pack://application:,,,/images/chapter.jpg", chapter7phy);
                var topic7_4 = new Topic("Pressure in liquids", 4, "pack://application:,,,/images/chapter.jpg", chapter7phy);
                var topic7_5 = new Topic("Elasticity", 5, "pack://application:,,,/images/chapter.jpg", chapter7phy);
                var topic7_6 = new Topic("Young's Modulus", 6, "pack://application:,,,/images/chapter.jpg", chapter7phy);

                var chapter8phy = new Chapter(8, "Thermal properties of matter", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic8_1 = new Topic("Temperature & Heat", 1 , "pack://application:,,,/images/chapter.jpg", chapter8phy);
                var topic8_2 = new Topic("Thermometer", 2, "pack://application:,,,/images/chapter.jpg", chapter8phy);
                var topic8_3 = new Topic("Specific Heat Capacity", 3, "pack://application:,,,/images/chapter.jpg", chapter8phy);
                var topic8_4 = new Topic("Latent heat of fusion", 4, "pack://application:,,,/images/chapter.jpg", chapter8phy);
                var topic8_5 = new Topic("Latent heat of vaporization", 5, "pack://application:,,,/images/chapter.jpg", chapter8phy);
                var topic8_6 = new Topic("Thermal Expansion", 6, "pack://application:,,,/images/chapter.jpg", chapter8phy);

                var chapter9phy = new Chapter(9, "Transfer of heat", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic9_1 = new Topic("Three process of heat transfer", 1 ,  "pack://application:,,,/images/chapter.jpg", chapter9phy);
                var topic9_2 = new Topic("Conduction", 2, "pack://application:,,,/images/chapter.jpg", chapter9phy);
                var topic9_3 = new Topic("Convection", 3, "pack://application:,,,/images/chapter.jpg", chapter9phy);
                var topic9_4 = new Topic("Radiation", 4, "pack://application:,,,/images/chapter.jpg", chapter9phy);
                var topic9_5 = new Topic("Application of heat transfer", 5, "pack://application:,,,/images/chapter.jpg", chapter9phy);
                







                // level9.subjects.Add(subjectPhy);        //adding physics to 9th level subjects list
                l.Subjects.Add(subjectPhy);
                subjectPhy.Chapters.Add(chapter1phy);   //adding  physics first chapter list in 9th level
                chapter1phy.Topics.Add(topicAbc);       //adding physics 1st chapter topic list in 9th level
                chapter1phy.Topics.Add(topicDef);
                chapter1phy.Topics.Add(topicGhi);
                chapter1phy.Topics.Add(topicJkl);
                chapter1phy.Topics.Add(topicJkl5);
                chapter1phy.Topics.Add(topicJkl6);
                chapter1phy.Topics.Add(topicJkl7);
                chapter1phy.Topics.Add(topicJkl8);
                chapter1phy.Topics.Add(topicJkl9);


                subjectPhy.Chapters.Add(chapter2phy); //adding  physics 2nd chapter list in 9th level
                chapter2phy.Topics.Add(topicAbc2);
                chapter2phy.Topics.Add(topicDef2);
                chapter2phy.Topics.Add(topicGhi2);
                chapter2phy.Topics.Add(topicJkl2);

                subjectPhy.Chapters.Add(chapter3phy); //adding  physics 3rd chapter list in 9th level
                chapter3phy.Topics.Add(topicAbc3);
                chapter3phy.Topics.Add(topicDef3);
                chapter3phy.Topics.Add(topicGhi3);
                chapter3phy.Topics.Add(topicJkl3);

                subjectPhy.Chapters.Add(chapter4phy); //adding  physics 4 chapter list in 9th level
                chapter4phy.Topics.Add(topic4_1);
                chapter4phy.Topics.Add(topic4_2);
                chapter4phy.Topics.Add(topic4_3);
                chapter4phy.Topics.Add(topic4_4);
                chapter4phy.Topics.Add(topic4_5);
                chapter4phy.Topics.Add(topic4_6);
                chapter4phy.Topics.Add(topic4_7);
                chapter4phy.Topics.Add(topic4_8);
                chapter4phy.Topics.Add(topic4_9);
                chapter4phy.Topics.Add(topic4_10);
                chapter4phy.Topics.Add(topic4_11);
                chapter4phy.Topics.Add(topic4_12);
                chapter4phy.Topics.Add(topic4_13);
                chapter4phy.Topics.Add(topic4_14);
                chapter4phy.Topics.Add(topic4_15);
                chapter4phy.Topics.Add(topic4_16);
                chapter4phy.Topics.Add(topic4_17);
                chapter4phy.Topics.Add(topic4_18);
                chapter4phy.Topics.Add(topic4_19);
                chapter4phy.Topics.Add(topic4_20);
                chapter4phy.Topics.Add(topic4_21);
                chapter4phy.Topics.Add(topic4_22);
                chapter4phy.Topics.Add(topic4_23);



                subjectPhy.Chapters.Add(chapter5phy); //adding  physics 5 chapter list in 9th level
                chapter5phy.Topics.Add(topic5_1);
                chapter5phy.Topics.Add(topic5_2);
                chapter5phy.Topics.Add(topic5_3);
                chapter5phy.Topics.Add(topic5_4);


                subjectPhy.Chapters.Add(chapter6phy); //adding  physics 6 chapter list in 9th level
                chapter6phy.Topics.Add(topic6_1);
                chapter6phy.Topics.Add(topic6_2);
                chapter6phy.Topics.Add(topic6_3);
                chapter6phy.Topics.Add(topic6_4);

                subjectPhy.Chapters.Add(chapter7phy); //adding  physics 7 chapter list in 9th level
                chapter7phy.Topics.Add(topic7_1);
                chapter7phy.Topics.Add(topic7_2);
                chapter7phy.Topics.Add(topic7_3);
                chapter7phy.Topics.Add(topic7_4);
                chapter7phy.Topics.Add(topic7_5);
                chapter7phy.Topics.Add(topic7_6);

                subjectPhy.Chapters.Add(chapter8phy); //adding  physics 8 chapter list in 9th level
                chapter8phy.Topics.Add(topic8_1);
                chapter8phy.Topics.Add(topic8_2);
                chapter8phy.Topics.Add(topic8_3);
                chapter8phy.Topics.Add(topic8_4);
                chapter8phy.Topics.Add(topic8_5);
                chapter8phy.Topics.Add(topic8_6);


                subjectPhy.Chapters.Add(chapter9phy); //adding  physics 9 chapter list in 9th level
                chapter9phy.Topics.Add(topic9_1);
                chapter9phy.Topics.Add(topic9_2);
                chapter9phy.Topics.Add(topic9_3);
                chapter9phy.Topics.Add(topic9_4);
                chapter9phy.Topics.Add(topic9_5);
                







                var chapter1Chem = new Chapter(1, "Fundamentals of Chemistry", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC1_1 = new Topic("chemistry Introduction", 1);
                var topicC1_2 = new Topic("Branches of chemistry", 2);
                var topicC1_3 = new Topic("Elements Compounds Mixture", 3);
                var topicC1_4 = new Topic("Chemical formula", 4);

                var chapter2Chem = new Chapter(2, "Structure of Atoms", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC2_1 = new Topic("", 1);
                var topicC2_2 = new Topic("", 2);
                var topicC2_3 = new Topic("", 3);
                var topicC2_4 = new Topic("", 4);

                var chapter3Chem = new Chapter(3, "Periodic Table and periodicity of properties", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC3_1 = new Topic("", 1);
                var topicC3_2 = new Topic("", 2);
                var topicC3_3 = new Topic("", 3);
                var topicC3_4 = new Topic("", 4);

                var chapter4Chem = new Chapter(4, "Structure of Molecules", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC4_1 = new Topic("", 1);
                var topicC4_2 = new Topic("", 2);
                var topicC4_3 = new Topic("", 3);
                var topicC4_4 = new Topic("", 4);

                var chapter5Chem = new Chapter(5, "Physical States of Matter", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC5_1 = new Topic("", 1);
                var topicC5_2 = new Topic("", 2);
                var topicC5_3 = new Topic("", 3);
                var topicC5_4 = new Topic("", 4);

                var chapter6Chem = new Chapter(6, "Solution", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC6_1 = new Topic("", 1);
                var topicC6_2 = new Topic("", 2);
                var topicC6_3 = new Topic("", 3);
                var topicC6_4 = new Topic("", 4);

                var chapter7Chem = new Chapter(7, "Electrochemistry", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC7_1 = new Topic("", 1);
                var topicC7_2 = new Topic("", 2);
                var topicC7_3 = new Topic("", 3);
                var topicC7_4 = new Topic("", 4);

                var chapter8Chem = new Chapter(8, "Chemical Reactivity", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC8_1 = new Topic("", 1);
                var topicC8_2 = new Topic("", 2);
                var topicC8_3 = new Topic("", 3);
                var topicC8_4 = new Topic("", 4);


                //level9.subjects.Add(subjectChem);
                l.Subjects.Add(subjectChem);
                subjectChem.Chapters.Add(chapter1Chem); //adding  chemistry first chapter list in 9th level
                chapter1Chem.Topics.Add(topicC1_1);      //adding chemistry 1st chapter topic list in 9th level
                chapter1Chem.Topics.Add(topicC1_2);
                chapter1Chem.Topics.Add(topicC1_3);
                chapter1Chem.Topics.Add(topicC1_4);

                subjectChem.Chapters.Add(chapter2Chem); //adding  chemistry 2 chapter list in 9th level
                chapter2Chem.Topics.Add(topicC2_1);      //adding chemistry 2  chapter topic list in 9th level
                chapter2Chem.Topics.Add(topicC2_2);
                chapter2Chem.Topics.Add(topicC2_3);
                chapter2Chem.Topics.Add(topicC2_4);

                subjectChem.Chapters.Add(chapter3Chem); //adding  chemistry 3 chapter list in 9th level
                chapter3Chem.Topics.Add(topicC3_1);      //adding chemistry 3  chapter topic list in 9th level
                chapter3Chem.Topics.Add(topicC3_2);
                chapter3Chem.Topics.Add(topicC3_3);
                chapter3Chem.Topics.Add(topicC3_4);

                subjectChem.Chapters.Add(chapter4Chem); //adding  chemistry 4 chapter list in 9th level
                chapter4Chem.Topics.Add(topicC4_1);      //adding chemistry 4  chapter topic list in 9th level
                chapter4Chem.Topics.Add(topicC4_2);
                chapter4Chem.Topics.Add(topicC4_3);
                chapter4Chem.Topics.Add(topicC4_4);

                subjectChem.Chapters.Add(chapter5Chem); //adding  chemistry 5 chapter list in 9th level
                chapter5Chem.Topics.Add(topicC5_1);      //adding chemistry 5  chapter topic list in 9th level
                chapter5Chem.Topics.Add(topicC5_2);
                chapter5Chem.Topics.Add(topicC5_3);
                chapter5Chem.Topics.Add(topicC5_4);

                subjectChem.Chapters.Add(chapter6Chem); //adding  chemistry 6 chapter list in 9th level
                chapter6Chem.Topics.Add(topicC6_1);      //adding chemistry 6  chapter topic list in 9th level
                chapter6Chem.Topics.Add(topicC6_2);
                chapter6Chem.Topics.Add(topicC6_3);
                chapter6Chem.Topics.Add(topicC6_4);

                subjectChem.Chapters.Add(chapter7Chem); //adding  chemistry 7 chapter list in 9th level
                chapter7Chem.Topics.Add(topicC7_1);      //adding chemistry 7  chapter topic list in 9th level
                chapter7Chem.Topics.Add(topicC7_2);
                chapter7Chem.Topics.Add(topicC7_3);
                chapter7Chem.Topics.Add(topicC7_4);

                subjectChem.Chapters.Add(chapter8Chem); //adding  chemistry 8 chapter list in 9th level
                chapter8Chem.Topics.Add(topicC8_1);      //adding chemistry 8  chapter topic list in 9th level
                chapter8Chem.Topics.Add(topicC8_2);
                chapter8Chem.Topics.Add(topicC8_3);
                chapter8Chem.Topics.Add(topicC8_4);




                var chapter1Bio = new Chapter(1, "Introduction to Biology", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB1_1 = new Topic("Introduction to Biology", 1);
                var topicB1_2 = new Topic("Branches", 2);
                var topicB1_3 = new Topic("Careers in Biology", 3);
                var topicB1_4 = new Topic("The Level of Organization", 4);

                var chapter2Bio = new Chapter(2, "Solving a Biological Problem", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB2_1 = new Topic("Biological Method", 1);
                var topicB2_2 = new Topic("Data Organization", 2);
                var topicB2_3 = new Topic("Data Analysis", 3);
                var topicB2_4 = new Topic("Study of Malaria ", 4);

                var chapter3Bio = new Chapter(3, "Biodiversity", "pack://application:,,,/images/chapter.jpg" , subjectBio);
                var topicB3_1 = new Topic("Classification Aims", 1);
                var topicB3_2 = new Topic("Bionomial Nomenclature", 2);
                var topicB3_3 = new Topic("Principles", 3);
                var topicB3_4 = new Topic("The five Kingdom", 4);

                var chapter4Bio = new Chapter(4, "Cells and Tissues", "pack://application:,,,/images/chapter.jpg" , subjectBio);
                var topicB4_1 = new Topic("Microscopy", 1);
                var topicB4_2 = new Topic("Cell structure and functions", 2);
                var topicB4_3 = new Topic("passage of molecules", 3);
                var topicB4_4 = new Topic("Animals and plants tissue", 4);

                var chapter5Bio = new Chapter(5, "Cell Cycle", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB5_1 = new Topic("Mitosis", 1);
                var topicB5_2 = new Topic("Meiosis", 2);
                var topicB5_3 = new Topic("Apopotosis", 3);
                var topicB5_4 = new Topic("Necrosis", 4);


                var chapter6Bio = new Chapter(6, "Enzymes", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB6_1 = new Topic("Characteristics of Enzyms", 1);
                var topicB6_2 = new Topic("Mechanisms of Enzyms", 2);
                var topicB6_3 = new Topic("Specificity of Enzyms", 3);
                var topicB6_4 = new Topic("Uses of Enzyms", 4);

                var chapter7Bio = new Chapter(7, "Bioenergetics", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB7_1 = new Topic("Role of ATP", 1);
                var topicB7_2 = new Topic("Photosynthesis", 2);
                var topicB7_3 = new Topic("Respiration", 3);
                var topicB7_4 = new Topic("Light/Dark Reaction", 4);


                var chapter8Bio = new Chapter(8, "Nutrition", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB8_1 = new Topic("Mineral Nutrition in plants", 1);
                var topicB8_2 = new Topic("Components of Human Food", 2);
                var topicB8_3 = new Topic("Digestion in Human", 3);
                var topicB8_4 = new Topic("Disorder of Gut", 4);

                var chapter9Bio = new Chapter(9, "Transport", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB9_1 = new Topic("Transport In plants", 1);
                var topicB9_2 = new Topic("Transport in Human", 2);
                var topicB9_3 = new Topic("Cardiovascular Disorder", 3);
                var topicB9_4 = new Topic("Myocardial Infarction", 4);

                //level9.subjects.Add(subjectBio);
                l.Subjects.Add(subjectBio);
                subjectBio.Chapters.Add(chapter1Bio); //adding  Bio first chapter list in 9th level
                chapter1Bio.Topics.Add(topicB1_1);      //adding BIO 1st chapter topic list in 9th level
                chapter1Bio.Topics.Add(topicB1_2);
                chapter1Bio.Topics.Add(topicB1_3);
                chapter1Bio.Topics.Add(topicB1_4);

                subjectBio.Chapters.Add(chapter2Bio); //adding  Bio Second chapter list in 9th level
                chapter2Bio.Topics.Add(topicB2_1);      //adding BIO Second  chapter topic list in 9th level
                chapter2Bio.Topics.Add(topicB2_2);
                chapter2Bio.Topics.Add(topicB2_3);
                chapter2Bio.Topics.Add(topicB2_4);

                subjectBio.Chapters.Add(chapter3Bio); //adding  Bio 3 chapter list in 9th level
                chapter3Bio.Topics.Add(topicB3_1);      //adding BIO 3  chapter topic list in 9th level
                chapter3Bio.Topics.Add(topicB3_2);
                chapter3Bio.Topics.Add(topicB3_3);
                chapter3Bio.Topics.Add(topicB3_4);

                subjectBio.Chapters.Add(chapter4Bio); //adding  Bio 4 chapter list in 9th level
                chapter4Bio.Topics.Add(topicB4_1);      //adding BIO 4  chapter topic list in 9th level
                chapter4Bio.Topics.Add(topicB4_2);
                chapter4Bio.Topics.Add(topicB4_3);
                chapter4Bio.Topics.Add(topicB4_4);

                subjectBio.Chapters.Add(chapter5Bio); //adding  Bio 5 chapter list in 9th level
                chapter5Bio.Topics.Add(topicB5_1);      //adding BIO 5  chapter topic list in 9th level
                chapter5Bio.Topics.Add(topicB5_2);
                chapter5Bio.Topics.Add(topicB5_3);
                chapter5Bio.Topics.Add(topicB5_4);

                subjectBio.Chapters.Add(chapter6Bio); //adding  Bio 6 chapter list in 9th level
                chapter6Bio.Topics.Add(topicB6_1);      //adding BIO 6  chapter topic list in 9th level
                chapter6Bio.Topics.Add(topicB6_2);
                chapter6Bio.Topics.Add(topicB6_3);
                chapter6Bio.Topics.Add(topicB6_4);


                subjectBio.Chapters.Add(chapter7Bio); //adding  Bio 7 chapter list in 9th level
                chapter7Bio.Topics.Add(topicB7_1);      //adding BIO 7  chapter topic list in 9th level
                chapter7Bio.Topics.Add(topicB7_2);
                chapter7Bio.Topics.Add(topicB7_3);
                chapter7Bio.Topics.Add(topicB7_4);

                subjectBio.Chapters.Add(chapter8Bio); //adding  Bio 8 chapter list in 9th level
                chapter8Bio.Topics.Add(topicB8_1);      //adding BIO 8  chapter topic list in 9th level
                chapter8Bio.Topics.Add(topicB8_2);
                chapter8Bio.Topics.Add(topicB8_3);
                chapter8Bio.Topics.Add(topicB8_4);




                var chapter1Maths = new Chapter(1, "Matrices and Determinants", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM1_1 = new Topic("Matrix", 1);
                var topicM1_2 = new Topic("Types of Matrices", 2);
                var topicM1_3 = new Topic("Addition and subtraction of Matrices", 3);
                var topicM1_4 = new Topic("Mutiplicative Inverse of Matrices", 4);

                var chapter2Maths = new Chapter(2, "Real and Complex Numbers", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM2_1 = new Topic("Real Numbers", 1);
                var topicM2_2 = new Topic("Properties of Real Numbers", 2);
                var topicM2_3 = new Topic("Radicals and Radicands", 3);
                var topicM2_4 = new Topic("Complex Numbers", 4);

                var chapter3Maths = new Chapter(3, "Logarithms", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM3_1 = new Topic("Scientific Notation", 1);
                var topicM3_2 = new Topic("Logarithm", 2);
                var topicM3_3 = new Topic("Common Logarithm and Natural Logarithm", 3);
                var topicM3_4 = new Topic("Law of Logarithm", 4);

                var chapter4Maths = new Chapter(4, "Algebraic Expressions and Algebraic Formula", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM4_1 = new Topic("Algebraic Expressions ", 1);
                var topicM4_2 = new Topic(" Algebraic Formula", 2);
                var topicM4_3 = new Topic("Surds and their Application", 3);
                var topicM4_4 = new Topic("Rationalize Surds", 4);

                var chapter5Maths = new Chapter(5, "Factorization", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM5_1 = new Topic("Factorization", 1);
                var topicM5_2 = new Topic("Remainder Theorem", 2);
                var topicM5_3 = new Topic("Factor Theorm", 3);
                var topicM5_4 = new Topic("Factorization of Cubical Polynomial", 4);

                var chapter6Maths = new Chapter(6, " Algebraic Manipulation", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM6_1 = new Topic("Highest Common Factor", 1);
                var topicM6_2 = new Topic("Least Common Factor", 2);
                var topicM6_3 = new Topic("Basic Operations on Algebraic Fractions", 3);
                var topicM6_4 = new Topic("Square Root of Algebraic Expression", 4);

                var chapter7Maths = new Chapter(7, " Linear Equations and Inequalities ", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM7_1 = new Topic(" Linear Equations", 1);
                var topicM7_2 = new Topic(" Equations Involving Absolute Value", 2);
                var topicM7_3 = new Topic(" Linear Inequalities", 3);
                var topicM7_4 = new Topic(" Solving Linear Inequalities", 4);

                var chapter8Maths = new Chapter(8, " Linear Graphs & Their Application", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM8_1 = new Topic("Cartesian Plane", 1);
                var topicM8_2 = new Topic("Linear Graphs", 2);
                var topicM8_3 = new Topic("Conversion Graphs", 3);
                var topicM8_4 = new Topic("Graphical Solution of linear Equations", 4);

                var chapter9Maths = new Chapter(9, " Introduction to Coordinate Geometry", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM9_1 = new Topic(" Distance Formula", 1);
                var topicM9_2 = new Topic("Collinear Points ", 2);
                var topicM9_3 = new Topic("Mid Point Formula ", 3);
                

                var chapter10Maths = new Chapter(10, " Congruent Triangles", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM10_1 = new Topic("Congruent Trianglesr", 1);
                


                //level9.subjects.Add(subjectMaths); //adding maths to level 9th subjects
                l.Subjects.Add(subjectMaths);

                subjectMaths.Chapters.Add(chapter1Maths); //adding  Maths first chapter list in 9th level
                chapter1Maths.Topics.Add(topicM1_1);      //adding Maths 1st chapter topic list in 9th level
                chapter1Maths.Topics.Add(topicM1_2);
                chapter1Maths.Topics.Add(topicM1_3);
                chapter1Maths.Topics.Add(topicM1_4);

                subjectMaths.Chapters.Add(chapter2Maths); //adding  Maths 2 chapter list in 9th level
                chapter2Maths.Topics.Add(topicM2_1);      //adding Maths 2  chapter topic list in 9th level
                chapter2Maths.Topics.Add(topicM2_2);
                chapter2Maths.Topics.Add(topicM2_3);
                chapter2Maths.Topics.Add(topicM2_4);


                subjectMaths.Chapters.Add(chapter3Maths); //adding  Maths 3 chapter list in 9th level
                chapter3Maths.Topics.Add(topicM3_1);      //adding Maths 3 chapter topic list in 9th level
                chapter3Maths.Topics.Add(topicM3_2);
                chapter3Maths.Topics.Add(topicM3_3);
                chapter3Maths.Topics.Add(topicM3_4);


                subjectMaths.Chapters.Add(chapter4Maths); //adding  Maths 4 chapter list in 9th level
                chapter4Maths.Topics.Add(topicM2_1);      //adding Maths 4 chapter topic list in 9th level
                chapter4Maths.Topics.Add(topicM2_2);
                chapter4Maths.Topics.Add(topicM2_3);
                chapter4Maths.Topics.Add(topicM2_4);

                subjectMaths.Chapters.Add(chapter5Maths); //adding  Maths 5 chapter list in 9th level
                chapter5Maths.Topics.Add(topicM5_1);      //adding Maths  5  chapter topic list in 9th level
                chapter5Maths.Topics.Add(topicM5_2);
                chapter5Maths.Topics.Add(topicM5_3);
                chapter5Maths.Topics.Add(topicM5_4);

                subjectMaths.Chapters.Add(chapter6Maths); //adding  Maths 6 chapter list in 9th level
                chapter6Maths.Topics.Add(topicM6_1);      //adding Maths  6 chapter topic list in 9th level
                chapter6Maths.Topics.Add(topicM6_2);
                chapter6Maths.Topics.Add(topicM6_3);
                chapter6Maths.Topics.Add(topicM6_4);

                subjectMaths.Chapters.Add(chapter7Maths); //adding  Maths 7 chapter list in 9th level
                chapter7Maths.Topics.Add(topicM7_1);      //adding Maths  7 chapter topic list in 9th level
                chapter7Maths.Topics.Add(topicM7_2);
                chapter7Maths.Topics.Add(topicM7_3);
                chapter7Maths.Topics.Add(topicM7_4);


                subjectMaths.Chapters.Add(chapter8Maths); //adding  Maths 8 chapter list in 9th level
                chapter8Maths.Topics.Add(topicM8_1);      //adding Maths  8 chapter topic list in 9th level
                chapter8Maths.Topics.Add(topicM8_2);
                chapter8Maths.Topics.Add(topicM8_3);
                chapter8Maths.Topics.Add(topicM8_4);

                subjectMaths.Chapters.Add(chapter9Maths); //adding  Maths 9 chapter list in 9th level
                chapter9Maths.Topics.Add(topicM9_1);      //adding Maths  9 chapter topic list in 9th level
                chapter9Maths.Topics.Add(topicM9_2);
                chapter9Maths.Topics.Add(topicM9_3);
                

                subjectMaths.Chapters.Add(chapter10Maths); //adding  Maths 10 chapter list in 9th level
                chapter10Maths.Topics.Add(topicM10_1);      //adding Maths  10 chapter topic list in 9th level
                


                return l;




            }
            else if (lname == 10)
            {
                 l = new Level(10);
                //level.Levelname = 10;
                var subjectPhy = new Subject("Physics10" ,l);
                var subjectChem = new Subject("Chemistry10",l);
                var subjectBio = new Subject("Bio10",l);
                var subjectMaths = new Subject("Maths10",l);

              

                var chapter1phy = new Chapter(1, "Simple Harmonic Motion", "pack://application:,,,/images/chapter.jpg",subjectPhy); // LEVEL 9 PHYSICS CHAPTER 1 declaration
                var topicAbc = new Topic("Simple Harmonic Motion (SHM)", 1);
                var topicDef = new Topic("Damped Oscillations", 2);
                var topicGhi = new Topic("Wave Motion", 3);
                var topicJkl = new Topic("Types of Mechanical Waves", 4);

                var chapter2phy = new Chapter(2, "Sound", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topicAbc2 = new Topic(" Sound Waves", 1);
                var topicDef2 = new Topic(" Characteristics of Sound ", 2);
                var topicGhi2 = new Topic(" Reflection (ECHO) of Sound", 3);
                var topicJkl2 = new Topic("Speed of Sound", 4);


                var chapter3phy = new Chapter(3, "Geometrical Optics", "pack://application:,,,/images/chapter.jpg" , subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topicAbc3 = new Topic("Reflection of Light", 1);
                var topicDef3 = new Topic(" Spherical Mirrors", 2);
                var topicGhi3 = new Topic("  Image Location by Spherical Mirror Form", 3);
                var topicJkl3 = new Topic(" Refraction of Light", 4);


                var chapter4phy = new Chapter(4, "Electrostatics", "pack://application:,,,/images/chapter.jpg" , subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic4_1 = new Topic("Production of Electric Charges", 1);
                var topic4_2 = new Topic("Electrostatic Induction", 2);
                var topic4_3 = new Topic(" Electroscope", 3);
                var topic4_4 = new Topic(" Coulomb's Law", 4);
                var topic4_5 = new Topic("Electric Field and Electric Field Inten", 5);
               

                var chapter5phy = new Chapter(5, "Current Electricity", "pack://application:,,,/images/chapter.jpg" , subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic5_1 = new Topic("Electric Current", 1);
                var topic5_2 = new Topic("Potential Difference", 2);
                var topic5_3 = new Topic(" Eletcromotive Force (e.m.f)", 3);
                var topic5_4 = new Topic("OHM'S Law", 4);


                var chapter6phy = new Chapter(6, "Electromagnetism", "pack://application:,,,/images/chapter.jpg" , subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic6_1 = new Topic("Magnetic Effect of a Steady Current", 1);
                var topic6_2 = new Topic("Force on a Current-Carrying Conductor", 2);
                var topic6_3 = new Topic("Turning Effect on a Curent-Carrying Coil", 3);
                var topic6_4 = new Topic("D.C Motor", 4);


                var chapter7phy = new Chapter(7, "Basic Electronics", "pack://application:,,,/images/chapter.jpg"  , subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic7_1 = new Topic("Thermionic Emission", 1);
                var topic7_2 = new Topic("Investigating the Properties of Electron", 2);
                var topic7_3 = new Topic("Cathode-Ray Oscilloscope (C.R.O)", 3);
                var topic7_4 = new Topic(" Analogue and Digital Electronics", 4);
                var topic7_5 = new Topic("  Basic Operations of Digital Electronics", 5);
                

                var chapter8phy = new Chapter(8, "Information and communication Technology", "pack://application:,,,/images/chapter.jpg", subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic8_1 = new Topic("Information and Communication Technology", 1);
                var topic8_2 = new Topic("Components of Computer Based Information", 2);
                var topic8_3 = new Topic("Flow of Information", 3);
                var topic8_4 = new Topic("Transmission of Electric Signal Through", 4);
                var topic8_5 = new Topic(" Transmissions of Radiowave Through Space", 5);
                

                var chapter9phy = new Chapter(9, "Atmoic and Nuclear Physics", "pack://application:,,,/images/chapter.jpg" , subjectPhy); //LEVEL 9 PHYSICS CHAPTER 2 declaration
                var topic9_1 = new Topic(" Atom and Atomic Nucleus", 1);
                var topic9_2 = new Topic("  Natural Radioactivity", 2);
                var topic9_3 = new Topic("  Background Radiations ", 3);
                var topic9_4 = new Topic("  Nuclear Transmutations", 4);
                var topic9_5 = new Topic("  Half-Life and its Measurement", 5);








                // level9.subjects.Add(subjectPhy);        //adding physics to 9th level subjects list
                l.Subjects.Add(subjectPhy);
                subjectPhy.Chapters.Add(chapter1phy);   //adding  physics first chapter list in 9th level
                chapter1phy.Topics.Add(topicAbc);       //adding physics 1st chapter topic list in 9th level
                chapter1phy.Topics.Add(topicDef);
                chapter1phy.Topics.Add(topicGhi);
                chapter1phy.Topics.Add(topicJkl);


                subjectPhy.Chapters.Add(chapter2phy); //adding  physics 2nd chapter list in 9th level
                chapter2phy.Topics.Add(topicAbc2);
                chapter2phy.Topics.Add(topicDef2);
                chapter2phy.Topics.Add(topicGhi2);
                chapter2phy.Topics.Add(topicJkl2);

                subjectPhy.Chapters.Add(chapter3phy); //adding  physics 3rd chapter list in 9th level
                chapter3phy.Topics.Add(topicAbc3);
                chapter3phy.Topics.Add(topicDef3);
                chapter3phy.Topics.Add(topicGhi3);
                chapter3phy.Topics.Add(topicJkl3);

                subjectPhy.Chapters.Add(chapter4phy); //adding  physics 4 chapter list in 9th level
                chapter4phy.Topics.Add(topic4_1);
                chapter4phy.Topics.Add(topic4_2);
                chapter4phy.Topics.Add(topic4_3);
                chapter4phy.Topics.Add(topic4_4);
                chapter4phy.Topics.Add(topic4_5);
               



                subjectPhy.Chapters.Add(chapter5phy); //adding  physics 5 chapter list in 9th level
                chapter5phy.Topics.Add(topic5_1);
                chapter5phy.Topics.Add(topic5_2);
                chapter5phy.Topics.Add(topic5_3);
                chapter5phy.Topics.Add(topic5_4);


                subjectPhy.Chapters.Add(chapter6phy); //adding  physics 6 chapter list in 9th level
                chapter6phy.Topics.Add(topic6_1);
                chapter6phy.Topics.Add(topic6_2);
                chapter6phy.Topics.Add(topic6_3);
                chapter6phy.Topics.Add(topic6_4);

                subjectPhy.Chapters.Add(chapter7phy); //adding  physics 7 chapter list in 9th level
                chapter7phy.Topics.Add(topic7_1);
                chapter7phy.Topics.Add(topic7_2);
                chapter7phy.Topics.Add(topic7_3);
                chapter7phy.Topics.Add(topic7_4);
                chapter7phy.Topics.Add(topic7_5);
               // chapter7phy.Topics.Add(topic7_6);

                subjectPhy.Chapters.Add(chapter8phy); //adding  physics 8 chapter list in 9th level
                chapter8phy.Topics.Add(topic8_1);
                chapter8phy.Topics.Add(topic8_2);
                chapter8phy.Topics.Add(topic8_3);
                chapter8phy.Topics.Add(topic8_4);
                chapter8phy.Topics.Add(topic8_5);
                //chapter8phy.Topics.Add(topic8_6);


                subjectPhy.Chapters.Add(chapter9phy); //adding  physics 9 chapter list in 9th level
                chapter9phy.Topics.Add(topic9_1);
                chapter9phy.Topics.Add(topic9_2);
                chapter9phy.Topics.Add(topic9_3);
                chapter9phy.Topics.Add(topic9_4);
                chapter9phy.Topics.Add(topic9_5);








                var chapter1Chem = new Chapter(1, "Chemical Equilibrium", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC1_1 = new Topic(" Reversible Reactions and Dynamic Equilibrium", 1);
                var topicC1_2 = new Topic("Law of Chemical Reaction", 2);
                var topicC1_3 = new Topic(" Equilibrium Constant Kc and its Units", 3);
                var topicC1_4 = new Topic(" Importance of Kc", 4);

                var chapter2Chem = new Chapter(2, "Acid Basis Salts", "pack://application:,,,/images/chapter.jpg" , subjectChem);
                var topicC2_1 = new Topic("Concept of Acids and Bases ", 1);
                var topicC2_2 = new Topic(" pH Scale", 2);
                var topicC2_3 = new Topic("Salts", 3);
                //var topicC2_4 = new Topic("", 4);

                var chapter3Chem = new Chapter(3, "Organic Chemistry", "pack://application:,,,/images/chapter.jpg" , subjectChem);
                var topicC3_1 = new Topic("Organic Compounds", 1);
                var topicC3_2 = new Topic(" Sources of Organic Compounds", 2);
                var topicC3_3 = new Topic(" Uses of Organic Compounds ", 3);
                var topicC3_4 = new Topic(" Alkane and Alkyle Radicals", 4);

                var chapter4Chem = new Chapter(4, "Hydrocarbans", "pack://application:,,,/images/chapter.jpg" , subjectChem);
                var topicC4_1 = new Topic(" Concept of Hydrocarbons", 1);
                var topicC4_2 = new Topic(" Alkanes", 2);
                var topicC4_3 = new Topic(" Alkenes ", 3);
                var topicC4_4 = new Topic("Alkynes", 4);

                var chapter5Chem = new Chapter(5, "Biochemistry", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC5_1 = new Topic(" Carbohydrates ", 1);
                var topicC5_2 = new Topic("  Protein ", 2);
                var topicC5_3 = new Topic("  Lipids", 3);
                var topicC5_4 = new Topic(" Nucleic Acids", 4);
                
                var chapter6Chem = new Chapter(6, "The Atmosphere", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC6_1 = new Topic(" Introduction to Atmosphere", 1);
                var topicC6_2 = new Topic("Composition of Atmosphere", 2);
                var topicC6_3 = new Topic(" Layers of Atmosphere", 3);
                var topicC6_4 = new Topic(" Pollutants", 4);

                var chapter7Chem = new Chapter(7, "Water", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC7_1 = new Topic("Introduction to Water", 1);
                var topicC7_2 = new Topic(" Properties of Water", 2);
                var topicC7_3 = new Topic("  Water as a Solvent ", 3);
                var topicC7_4 = new Topic(" Soft and Hard Water", 4);

                var chapter8Chem = new Chapter(8, "Chemical Industries", "pack://application:,,,/images/chapter.jpg", subjectChem);
                var topicC8_1 = new Topic(" Introduction to Chemical Industries", 1);
                var topicC8_2 = new Topic(" Basic Metallurgical Operations ", 2);
                var topicC8_3 = new Topic("Manufacture of Sodium Carbonates", 3);
                var topicC8_4 = new Topic(" Manufacture of Urea", 4);


                //level9.subjects.Add(subjectChem);
                l.Subjects.Add(subjectChem);
                subjectChem.Chapters.Add(chapter1Chem); //adding  chemistry first chapter list in 9th level
                chapter1Chem.Topics.Add(topicC1_1);      //adding chemistry 1st chapter topic list in 9th level
                chapter1Chem.Topics.Add(topicC1_2);
                chapter1Chem.Topics.Add(topicC1_3);
                chapter1Chem.Topics.Add(topicC1_4);

                subjectChem.Chapters.Add(chapter2Chem); //adding  chemistry 2 chapter list in 9th level
                chapter2Chem.Topics.Add(topicC2_1);      //adding chemistry 2  chapter topic list in 9th level
                chapter2Chem.Topics.Add(topicC2_2);
                chapter2Chem.Topics.Add(topicC2_3);
              //  chapter2Chem.Topics.Add(topicC2_4);

                subjectChem.Chapters.Add(chapter3Chem); //adding  chemistry 3 chapter list in 9th level
                chapter3Chem.Topics.Add(topicC3_1);      //adding chemistry 3  chapter topic list in 9th level
                chapter3Chem.Topics.Add(topicC3_2);
                chapter3Chem.Topics.Add(topicC3_3);
                chapter3Chem.Topics.Add(topicC3_4);

                subjectChem.Chapters.Add(chapter4Chem); //adding  chemistry 4 chapter list in 9th level
                chapter4Chem.Topics.Add(topicC4_1);      //adding chemistry 4  chapter topic list in 9th level
                chapter4Chem.Topics.Add(topicC4_2);
                chapter4Chem.Topics.Add(topicC4_3);
                chapter4Chem.Topics.Add(topicC4_4);

                subjectChem.Chapters.Add(chapter5Chem); //adding  chemistry 5 chapter list in 9th level
                chapter5Chem.Topics.Add(topicC5_1);      //adding chemistry 5  chapter topic list in 9th level
                chapter5Chem.Topics.Add(topicC5_2);
                chapter5Chem.Topics.Add(topicC5_3);
                chapter5Chem.Topics.Add(topicC5_4);

                subjectChem.Chapters.Add(chapter6Chem); //adding  chemistry 6 chapter list in 9th level
                chapter6Chem.Topics.Add(topicC6_1);      //adding chemistry 6  chapter topic list in 9th level
                chapter6Chem.Topics.Add(topicC6_2);
                chapter6Chem.Topics.Add(topicC6_3);
                chapter6Chem.Topics.Add(topicC6_4);

                subjectChem.Chapters.Add(chapter7Chem); //adding  chemistry 7 chapter list in 9th level
                chapter7Chem.Topics.Add(topicC7_1);      //adding chemistry 7  chapter topic list in 9th level
                chapter7Chem.Topics.Add(topicC7_2);
                chapter7Chem.Topics.Add(topicC7_3);
                chapter7Chem.Topics.Add(topicC7_4);

                subjectChem.Chapters.Add(chapter8Chem); //adding  chemistry 8 chapter list in 9th level
                chapter8Chem.Topics.Add(topicC8_1);      //adding chemistry 8  chapter topic list in 9th level
                chapter8Chem.Topics.Add(topicC8_2);
                chapter8Chem.Topics.Add(topicC8_3);
                chapter8Chem.Topics.Add(topicC8_4);




                var chapter1Bio = new Chapter(1, "Gaseous Exchange", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB1_1 = new Topic("", 1);
                var topicB1_2 = new Topic("", 2);
                var topicB1_3 = new Topic("", 3);
                var topicB1_4 = new Topic("", 4);

                var chapter2Bio = new Chapter(2, " Homeostasis", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB2_1 = new Topic("", 1);
                var topicB2_2 = new Topic("", 2);
                var topicB2_3 = new Topic("", 3);
                var topicB2_4 = new Topic(" ", 4);

                var chapter3Bio = new Chapter(3, "Coordination and Control", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB3_1 = new Topic("", 1);
                var topicB3_2 = new Topic("", 2);
                var topicB3_3 = new Topic("", 3);
                var topicB3_4 = new Topic("", 4);

                var chapter4Bio = new Chapter(4, " Support and Movement", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB4_1 = new Topic("", 1);
                var topicB4_2 = new Topic("", 2);
                var topicB4_3 = new Topic("", 3);
                var topicB4_4 = new Topic("", 4);

                var chapter5Bio = new Chapter(5, " Reproduction", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB5_1 = new Topic("", 1);
                var topicB5_2 = new Topic("", 2);
                var topicB5_3 = new Topic("", 3);
                var topicB5_4 = new Topic("", 4);


                var chapter6Bio = new Chapter(6, "  Man and His Environment", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB6_1 = new Topic("", 1);
                var topicB6_2 = new Topic("", 2);
                var topicB6_3 = new Topic("", 3);
                var topicB6_4 = new Topic("", 4);

                var chapter7Bio = new Chapter(7, "  Biotechnology", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB7_1 = new Topic("", 1);
                var topicB7_2 = new Topic("", 2);
                var topicB7_3 = new Topic("", 3);
                var topicB7_4 = new Topic("", 4);


                var chapter8Bio = new Chapter(8, " Pharmacology", "pack://application:,,,/images/chapter.jpg", subjectBio);
                var topicB8_1 = new Topic("", 1);
                var topicB8_2 = new Topic("", 2);
                var topicB8_3 = new Topic("", 3);
                var topicB8_4 = new Topic("", 4);

               

                //level9.subjects.Add(subjectBio);
                l.Subjects.Add(subjectBio);
                subjectBio.Chapters.Add(chapter1Bio); //adding  Bio first chapter list in 9th level
                chapter1Bio.Topics.Add(topicB1_1);      //adding BIO 1st chapter topic list in 9th level
                chapter1Bio.Topics.Add(topicB1_2);
                chapter1Bio.Topics.Add(topicB1_3);
                chapter1Bio.Topics.Add(topicB1_4);

                subjectBio.Chapters.Add(chapter2Bio); //adding  Bio Second chapter list in 9th level
                chapter2Bio.Topics.Add(topicB2_1);      //adding BIO Second  chapter topic list in 9th level
                chapter2Bio.Topics.Add(topicB2_2);
                chapter2Bio.Topics.Add(topicB2_3);
                chapter2Bio.Topics.Add(topicB2_4);

                subjectBio.Chapters.Add(chapter3Bio); //adding  Bio 3 chapter list in 9th level
                chapter3Bio.Topics.Add(topicB3_1);      //adding BIO 3  chapter topic list in 9th level
                chapter3Bio.Topics.Add(topicB3_2);
                chapter3Bio.Topics.Add(topicB3_3);
                chapter3Bio.Topics.Add(topicB3_4);

                subjectBio.Chapters.Add(chapter4Bio); //adding  Bio 4 chapter list in 9th level
                chapter4Bio.Topics.Add(topicB4_1);      //adding BIO 4  chapter topic list in 9th level
                chapter4Bio.Topics.Add(topicB4_2);
                chapter4Bio.Topics.Add(topicB4_3);
                chapter4Bio.Topics.Add(topicB4_4);

                subjectBio.Chapters.Add(chapter5Bio); //adding  Bio 5 chapter list in 9th level
                chapter5Bio.Topics.Add(topicB5_1);      //adding BIO 5  chapter topic list in 9th level
                chapter5Bio.Topics.Add(topicB5_2);
                chapter5Bio.Topics.Add(topicB5_3);
                chapter5Bio.Topics.Add(topicB5_4);

                subjectBio.Chapters.Add(chapter6Bio); //adding  Bio 6 chapter list in 9th level
                chapter6Bio.Topics.Add(topicB6_1);      //adding BIO 6  chapter topic list in 9th level
                chapter6Bio.Topics.Add(topicB6_2);
                chapter6Bio.Topics.Add(topicB6_3);
                chapter6Bio.Topics.Add(topicB6_4);


                subjectBio.Chapters.Add(chapter7Bio); //adding  Bio 7 chapter list in 9th level
                chapter7Bio.Topics.Add(topicB7_1);      //adding BIO 7  chapter topic list in 9th level
                chapter7Bio.Topics.Add(topicB7_2);
                chapter7Bio.Topics.Add(topicB7_3);
                chapter7Bio.Topics.Add(topicB7_4);

                subjectBio.Chapters.Add(chapter8Bio); //adding  Bio 8 chapter list in 9th level
                chapter8Bio.Topics.Add(topicB8_1);      //adding BIO 8  chapter topic list in 9th level
                chapter8Bio.Topics.Add(topicB8_2);
                chapter8Bio.Topics.Add(topicB8_3);
                chapter8Bio.Topics.Add(topicB8_4);




                var chapter1Maths = new Chapter(1, "Quadratic Equations", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM1_1 = new Topic("", 1);
                var topicM1_2 = new Topic("", 2);
                var topicM1_3 = new Topic("", 3);
                var topicM1_4 = new Topic("", 4);

                var chapter2Maths = new Chapter(2, "Theory of Quadratic Equations", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM2_1 = new Topic("", 1);
                var topicM2_2 = new Topic("", 2);
                var topicM2_3 = new Topic("", 3);
                var topicM2_4 = new Topic("", 4);

                var chapter3Maths = new Chapter(3, " Variations", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM3_1 = new Topic("", 1);
                var topicM3_2 = new Topic("", 2);
                var topicM3_3 = new Topic("", 3);
                var topicM3_4 = new Topic("", 4);

                var chapter4Maths = new Chapter(4, "Partial Fractions", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM4_1 = new Topic(" ", 1);
                var topicM4_2 = new Topic(" ", 2);
                var topicM4_3 = new Topic("", 3);
                var topicM4_4 = new Topic("", 4);

                var chapter5Maths = new Chapter(5, " Sets and Functions", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM5_1 = new Topic("", 1);
                var topicM5_2 = new Topic("", 2);
                var topicM5_3 = new Topic("", 3);
                var topicM5_4 = new Topic("", 4);

                var chapter6Maths = new Chapter(6, " Basic Statistics ", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM6_1 = new Topic("", 1);
                var topicM6_2 = new Topic("", 2);
                var topicM6_3 = new Topic("", 3);
                var topicM6_4 = new Topic("", 4);

                var chapter7Maths = new Chapter(7, "  Introduction to Trigonometry", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM7_1 = new Topic(" ", 1);
                var topicM7_2 = new Topic(" ", 2);
                var topicM7_3 = new Topic(" ", 3);
                var topicM7_4 = new Topic(" ", 4);

                var chapter8Maths = new Chapter(8, " Projection of a Side of a Triangle ", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM8_1 = new Topic("", 1);
                var topicM8_2 = new Topic("", 2);
                var topicM8_3 = new Topic("", 3);
                var topicM8_4 = new Topic("", 4);

                var chapter9Maths = new Chapter(9, "Chords of a Circle", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM9_1 = new Topic(" ", 1);
                var topicM9_2 = new Topic(" ", 2);
                var topicM9_3 = new Topic("", 3);


                var chapter10Maths = new Chapter(10, " Tangent to a Circle", "pack://application:,,,/images/chapter.jpg" , subjectMaths);
                var topicM10_1 = new Topic("Congruent Trianglesr", 1);

                var chapter11Maths = new Chapter(11, " Chords and Arcs", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM11_1 = new Topic("Congruent Trianglesr", 1);

                var chapter12Maths = new Chapter(12, " Angle in a Segment of a Circle", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM12_1 = new Topic("", 1);

                var chapter13Maths = new Chapter(13, "  Practical Geometry- Circles", "pack://application:,,,/images/chapter.jpg", subjectMaths);
                var topicM13_1 = new Topic("", 1);


                //level9.subjects.Add(subjectMaths); //adding maths to level 9th subjects
                l.Subjects.Add(subjectMaths);

                subjectMaths.Chapters.Add(chapter1Maths); //adding  Maths first chapter list in 9th level
                chapter1Maths.Topics.Add(topicM1_1);      //adding Maths 1st chapter topic list in 9th level
                chapter1Maths.Topics.Add(topicM1_2);
                chapter1Maths.Topics.Add(topicM1_3);
                chapter1Maths.Topics.Add(topicM1_4);

                subjectMaths.Chapters.Add(chapter2Maths); //adding  Maths 2 chapter list in 9th level
                chapter2Maths.Topics.Add(topicM2_1);      //adding Maths 2  chapter topic list in 9th level
                chapter2Maths.Topics.Add(topicM2_2);
                chapter2Maths.Topics.Add(topicM2_3);
                chapter2Maths.Topics.Add(topicM2_4);


                subjectMaths.Chapters.Add(chapter3Maths); //adding  Maths 3 chapter list in 9th level
                chapter3Maths.Topics.Add(topicM3_1);      //adding Maths 3 chapter topic list in 9th level
                chapter3Maths.Topics.Add(topicM3_2);
                chapter3Maths.Topics.Add(topicM3_3);
                chapter3Maths.Topics.Add(topicM3_4);


                subjectMaths.Chapters.Add(chapter4Maths); //adding  Maths 4 chapter list in 9th level
                chapter4Maths.Topics.Add(topicM2_1);      //adding Maths 4 chapter topic list in 9th level
                chapter4Maths.Topics.Add(topicM2_2);
                chapter4Maths.Topics.Add(topicM2_3);
                chapter4Maths.Topics.Add(topicM2_4);

                subjectMaths.Chapters.Add(chapter5Maths); //adding  Maths 5 chapter list in 9th level
                chapter5Maths.Topics.Add(topicM5_1);      //adding Maths  5  chapter topic list in 9th level
                chapter5Maths.Topics.Add(topicM5_2);
                chapter5Maths.Topics.Add(topicM5_3);
                chapter5Maths.Topics.Add(topicM5_4);

                subjectMaths.Chapters.Add(chapter6Maths); //adding  Maths 6 chapter list in 9th level
                chapter6Maths.Topics.Add(topicM6_1);      //adding Maths  6 chapter topic list in 9th level
                chapter6Maths.Topics.Add(topicM6_2);
                chapter6Maths.Topics.Add(topicM6_3);
                chapter6Maths.Topics.Add(topicM6_4);

                subjectMaths.Chapters.Add(chapter7Maths); //adding  Maths 7 chapter list in 9th level
                chapter7Maths.Topics.Add(topicM7_1);      //adding Maths  7 chapter topic list in 9th level
                chapter7Maths.Topics.Add(topicM7_2);
                chapter7Maths.Topics.Add(topicM7_3);
                chapter7Maths.Topics.Add(topicM7_4);


                subjectMaths.Chapters.Add(chapter8Maths); //adding  Maths 8 chapter list in 9th level
                chapter8Maths.Topics.Add(topicM8_1);      //adding Maths  8 chapter topic list in 9th level
                chapter8Maths.Topics.Add(topicM8_2);
                chapter8Maths.Topics.Add(topicM8_3);
                chapter8Maths.Topics.Add(topicM8_4);

                subjectMaths.Chapters.Add(chapter9Maths); //adding  Maths 9 chapter list in 9th level
                chapter9Maths.Topics.Add(topicM9_1);      //adding Maths  9 chapter topic list in 9th level
                chapter9Maths.Topics.Add(topicM9_2);
                chapter9Maths.Topics.Add(topicM9_3);


                subjectMaths.Chapters.Add(chapter10Maths); //adding  Maths 10 chapter list in 9th level
                chapter10Maths.Topics.Add(topicM10_1);      //adding Maths  10 chapter topic list in 9th level

                subjectMaths.Chapters.Add(chapter11Maths); //adding  Maths 10 chapter list in 9th level
                chapter11Maths.Topics.Add(topicM11_1);      //adding Maths  10 chapter topic list in 9th level

                subjectMaths.Chapters.Add(chapter12Maths); //adding  Maths 10 chapter list in 9th level
                chapter12Maths.Topics.Add(topicM12_1);      //adding Maths  10 chapter topic list in 9th level

                subjectMaths.Chapters.Add(chapter13Maths); //adding  Maths 10 chapter list in 9th level
                chapter13Maths.Topics.Add(topicM13_1);      //adding Maths  10 chapter topic list in 9th level

                return l;


            }


            return l;

        }

    }
}

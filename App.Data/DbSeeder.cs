using App.Data.Entity;
namespace App.Data
{
    public class DbSeeder
    {
        private readonly AppDbContext _context;

        public DbSeeder(AppDbContext context)
        {
            _context = context;
        }

        public static void Seed(AppDbContext context)
        {
            SeedDepartments(context);
            // SeedImages(context);
            SeedRoles(context);
            SeedDoctors(context);
            SeedPatients(context);
            SeedPosts(context);
            SeedPostComments(context);
            SeedSettings(context);
            SeedUsers(context);
            SeedPages(context);
            SeedDepartmentPosts(context);
            SeedAppointments(context);
            SeedContacts(context);
            SeedSubscribber(context);
        }


        //burdayım be burdayım

        private static void SeedDepartments(AppDbContext context)
        {

            var department = new Department
            {
                Name = $"Opthomology",
                Image = "/Images/Opthomology.jpg",
                Description = $"Ophthalmology, the branch of medicine dedicated to studying and treating disorders and diseases of the eyes and visual system. Ophthalmologists are specialized medical professionals who diagnose and manage various eye conditions, from common refractive errors like nearsightedness and farsightedness to more complex issues such as cataracts, glaucoma, and retinal disorders. They employ advanced diagnostic tools and cutting-edge surgical techniques to provide patients with exceptional care for their vision and overall eye health. Regular eye check-ups with ophthalmologists play a pivotal role in early detection and timely treatment of eye-related problems, ensuring individuals maintain clear vision and prevent potential sight-threatening conditions.",
                // Gerekli diğer özellikler doldur.
            };

            var department2 = new Department
            {
                Name = $"Cardiology",
                Image = "/Images/Cardiology.jpg",
                Description = $"Cardiology, the specialized medical field devoted to diagnosing, treating, and preventing diseases and conditions related to the heart and the cardiovascular system. Cardiologists are highly trained medical professionals who specialize in understanding the intricacies of heart function and its interaction with blood vessels. They employ a variety of diagnostic techniques, such as electrocardiograms (ECGs), echocardiograms, and stress tests, to evaluate heart health and identify potential issues. Cardiologists manage a wide spectrum of heart conditions, including coronary artery disease, heart failure, arrhythmias, and congenital heart defects. Treatment approaches in cardiology encompass lifestyle changes, medications, minimally invasive procedures, and, in certain cases, complex surgeries.",
                // Gerekli diğer özellikler doldur.
            };

            var department3 = new Department
            {
                Name = $"Dental Care",
                Image = "/Images/DentalCare.jpg",
                Description = $"Dental care encompasses the practices aimed at maintaining oral hygiene and preventing as well as treating dental diseases. It holds a critical role in overall health and well-being. Dental care involves routine dental check-ups, daily brushing, flossing, and proper nutrition to uphold healthy teeth and gums. Dentists and dental hygienists are essential contributors to dental care services. During regular check-ups, they examine teeth and gums, professionally clean teeth, and identify potential dental issues such as cavities, gum disease, or oral infections.",
                // Gerekli diğer özellikler doldur.
            };

            var department4 = new Department
            {
                Name = $"Child Care",
                Image = "/Images/ChildCare.jpg",
                Description = $"Child care pertains to the supervision and nurturing of children in their formative years, undertaken by caregivers, parents, or professionals. It is a pivotal aspect of a child's holistic development, ensuring their safety, well-being, and overall growth. Child care takes various forms, including home-based care provided by parents or family members, and center-based care encompassing daycare centers, nurseries, and preschools.",
                // Gerekli diğer özellikler doldur.
            };

            var department5 = new Department
            {
                Name = $"Pulmonology",
                Image = "/Images/Pulmology.jpg",
                Description = $"Pulmonology, the specialized medical field dedicated to the study and treatment of diseases and disorders related to the respiratory system. Pulmonologists are expert physicians who diagnose and manage an array of respiratory conditions, including but not limited to asthma, chronic obstructive pulmonary disease (COPD), pneumonia, lung cancer, and interstitial lung diseases. They employ advanced diagnostic tools such as pulmonary function tests, chest X-rays, CT scans, and bronchoscopy to assess lung health and pinpoint specific respiratory issues.",
                // Gerekli diğer özellikler doldur.
            };

            var department6 = new Department
            {
                Name = $"Gynecology",
                Image = "/Images/Gynecology.jpg",
                Description = $"Gynecology, the medical specialty focused on the health and well-being of the female reproductive system. Gynecologists are specialized physicians who specialize in diagnosing and treating a wide range of conditions concerning the female reproductive organs, including the uterus, ovaries, fallopian tubes, and breasts. These medical professionals provide crucial services for women across all life stages, from adolescence through menopause and beyond.",
                // Gerekli diğer özellikler doldur.
            };

            var department7 = new Department
            {
                Name = $"Allergy And Immunology",
                Image = "/Images/AllergyAndImmunology.jpg",
                Description = $"Allergy and Immunology Department at our facility is dedicated to addressing allergies, including asthma, which are among the most prevalent health issues. We also provide expertise in immunodeficiencies, which, while rarer, can be chronic and debilitating if not accurately diagnosed and treated. Our division offers tailored care for both children and adults, encompassing a broad spectrum of allergic and immunologic conditions.",
                // Gerekli diğer özellikler doldur.
            };

            var department8 = new Department
            {
                Name = $"Anesthesiology",
                Image = "/Images/Anesthesiology.jpg",
                Description = $"Anesthesiology is a specialized medical field that centers on anesthesia administration. Anesthesia can range from local anesthetic injections that numb specific body parts, like a finger or an area around a tooth, to the use of potent drugs that induce unconsciousness.",
                // Gerekli diğer özellikler doldur.
            };

            var department9 = new Department
            {
                Name = $"Aviation Medical Services",
                Image = "/Images/AviationMedicalServices.jpg",
                Description = $"Our Aviation Medical Services Department provides exceptional care for aviation professionals in Dubai. Our team of certified Specialist Aeromedical Examiners conducts specialized aviation medical examinations for air traffic controllers, commercial pilots, private pilots, and cabin crew members, ensuring their fitness for duty and safe performance in their roles.",
                // Gerekli diğer özellikler doldur.
            };

            var department10 = new Department
            {
                Name = $"General Surgery",
                Image = "/Images/GeneralSurgery.jpg",
                Description = $"The General Surgery Department at American Hospital Dubai is committed to delivering comprehensive surgical healthcare at the highest international standards. We are the preferred choice for general surgery in Dubai, known for our excellence in patient care and surgical expertise.",
                // Gerekli diğer özellikler doldur.
            };

            var department11 = new Department
            {
                Name = $"Psychiatrist",
                Image = "/Images/Psychiatrist.jpg",
                Description = $"Psychiatry is the medical specialty devoted to diagnosing, treating, and preventing mental illnesses and emotional disorders. Psychiatrists are medical doctors who specialize in understanding the intricate interplay between a person's psychological, emotional, and physiological factors, providing comprehensive mental healthcare services.",
                // Gerekli diğer özellikler doldur.
            };
            context.Departments.Add(department);
            context.Departments.Add(department2);
            context.Departments.Add(department3);
            context.Departments.Add(department4);
            context.Departments.Add(department5);
            context.Departments.Add(department6);
            context.Departments.Add(department7);
            context.Departments.Add(department8);
            context.Departments.Add(department9);
            context.Departments.Add(department10);
            context.Departments.Add(department11);


            context.SaveChanges();
        }

        private static void SeedDoctors(AppDbContext context)
        {

            var doctor = new Doctors
            {
                RoleId = 2,
                FullName = $"Devrani POINTER",
                Image = "/Images/doctor1.jpg",
                City = $"Arizona",
                Phone = $"09008008080",
                Specialty = $"Opthomology",
                Email = GenerateRandomEmail($"Doctor", "mvccms.com"),
                Password = "123123",
                DepartmentId = 1
            };

            var doctor2 = new Doctors
            {
                RoleId = 2,
                FullName = $"Alparslan KOBAK",
                Image = "/Images/doctorAlparslan.jpg",
                City = $"Istanbul",
                Phone = $"9874561230",
                Specialty = $"Cardiology",
                Email = "kobak@webmvc.com",
                Password = "123456",
                DepartmentId = 2
            };

            var doctor3 = new Doctors
            {
                RoleId = 2,
                FullName = $"Kadir ALTINAY",
                Image = "/Images/doctorKadir.jpg",
                City = $"Warsaw",
                Phone = $"9874563210",
                Specialty = $"Psychiatrist",
                Email = "altinay@webmvc.com",
                Password = "123456",
                DepartmentId = 11
            };

            var doctor4 = new Doctors
            {
                RoleId = 2,
                FullName = $"Utku Kemal CICEK",
                Image = "/Images/doctorUtku.jpg",
                City = $"Bursa",
                Phone = $"9999999999",
                Specialty = $"Aviation Medical Services",
                Email = "cicek@webmvc.com",
                Password = "393939",
                DepartmentId = 9
            };

            var doctor5 = new Doctors
            {
                RoleId = 2,
                FullName = $"Serkan BILSEL",
                Image = "/Images/doctorSerkan.jpg",
                City = $"Izmir",
                Phone = $"2134567890",
                Specialty = $"Dental Care",
                Email = "bilsel@webmvc.com",
                Password = "123456",
                DepartmentId = 3
            };

            var doctor6 = new Doctors
            {
                RoleId = 2,
                FullName = $"Bulent OKTAY",
                Image = "/Images/doctorBulent.jpg",
                City = $"Ankara",
                Phone = $"7896541230",
                Specialty = $"Child Care",
                Email = "turkmen@webmvc.com",
                Password = "123456",
                DepartmentId = 4
            };

            var doctor7 = new Doctors
            {
                RoleId = 2,
                FullName = $"Muharrem INAN",
                Image = "/Images/doctorMuharrem.jpg",
                City = $"Istanbul",
                Phone = $"9876549840",
                Specialty = $"Pulmology",
                Email = "inan@webmvc.com",
                Password = "123456",
                DepartmentId = 5
            };

            var doctor8 = new Doctors
            {
                RoleId = 2,
                FullName = $"Ilker SARIKAYA",
                Image = "/Images/doctorilker.jpg",
                City = $"Istanbul",
                Phone = $"7897894563",
                Specialty = $"Gynecology",
                Email = "sarikaya@webmvc.com",
                Password = "123456",
                DepartmentId = 6
            };

            var doctor9 = new Doctors
            {
                RoleId = 2,
                FullName = $"Haydar ARAS",
                Image = "/Images/doctorHaydar.jpg",
                City = $"Eskisehir",
                Phone = $"9879871350",
                Specialty = $"Allergy And Immunology",
                Email = "aras@webmvc.com",
                Password = "123456",
                DepartmentId = 7
            };

            var doctor10 = new Doctors
            {
                RoleId = 2,
                FullName = $"Ozlem OYMAK",
                Image = "/Images/doctorOzlem.jpg",
                City = $"Bursa",
                Phone = $"1597532580",
                Specialty = $"Anesthesiology",
                Email = "oymak@webmvc.com",
                Password = "123456",
                DepartmentId = 8
            };

            var doctor11 = new Doctors
            {
                RoleId = 2,
                FullName = $"Serdar YALMAN",
                Image = "/Images/doctorSerdar.jpg",
                City = $"Eskisehir",
                Phone = $"7538521594",
                Specialty = $"General Surgery",
                Email = "yalman@webmvc.com",
                Password = "123456",
                DepartmentId = 10
            };

            context.Doctors.Add(doctor);
            context.Doctors.Add(doctor2);
            context.Doctors.Add(doctor3);
            context.Doctors.Add(doctor4);
            context.Doctors.Add(doctor5);
            context.Doctors.Add(doctor6);
            context.Doctors.Add(doctor7);
            context.Doctors.Add(doctor8);
            context.Doctors.Add(doctor9);
            context.Doctors.Add(doctor10);
            context.Doctors.Add(doctor11);
            context.SaveChanges();
        }



        private static void SeedPatients(AppDbContext context)
        {

            var patient = new Patient
            {
                Diagnosis = $"Vision Problems",
                Image = "/Images/patient1.jpg",
                RoleId = 3,
                FullName = $"Hakkı BULUT",
                City = $"Arizona",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 1
            };

            var patient2 = new Patient
            {
                Diagnosis = $"Chest Palpitations",
                Image = "/Images/patient2.jpg",
                RoleId = 3,
                FullName = $"Aylin YILMAZ",
                City = $"Istanbul",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 2
            };

            var patient3 = new Patient
            {
                Diagnosis = $"Tooth Extraction",
                Image = "/Images/patient3.jpg",
                RoleId = 3,
                FullName = $"Emre KAYA",
                City = $"Izmir",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 3
            };

            var patient4 = new Patient
            {
                Diagnosis = $"Feverish Toddler",
                Image = "/Images/patient4.jpg",
                RoleId = 3,
                FullName = $"Elif SAHIN",
                City = $"Ankara",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 4
            };

            var patient5 = new Patient
            {
                Diagnosis = $"Chronic Cough",
                Image = "/Images/patient5.jpg",
                RoleId = 3,
                FullName = $"Burak ARSLAN",
                City = $"Istanbul",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 5
            };

            var patient6 = new Patient
            {
                Diagnosis = $"Irregular Periods",
                Image = "/Images/patient6.jpg",
                RoleId = 3,
                FullName = $"Deniz KAYAN",
                City = $"Istanbul",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 6
            };

            var patient7 = new Patient
            {
                Diagnosis = $"Allergic Reaction",
                Image = "/Images/patient7.jpg",
                RoleId = 3,
                FullName = $"Fırat DEMIR",
                City = $"Eskisehir",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 7
            };

            var patient8 = new Patient
            {
                Diagnosis = $"Surgical Sedation",
                Image = "/Images/patient8.jpg",
                RoleId = 3,
                FullName = $"Gizem YILDIRIM",
                City = $"Bursa",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 8
            };

            var patient9 = new Patient
            {
                Diagnosis = $"Pilot Checkup",
                Image = "/Images/patient9.jpg",
                RoleId = 3,
                FullName = $"Ipek AKSOY",
                City = $"Bursa",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 9
            };

            var patient10 = new Patient
            {
                Diagnosis = $"Appendectomy Surgery",
                Image = "/Images/patient10.jpg",
                RoleId = 3,
                FullName = $"Lale PAK",
                City = $"Eskisehir",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 10
            };

            var patient11 = new Patient
            {
                Diagnosis = $"Sleep Disorder",
                Image = "/Images/patient11.jpg",
                RoleId = 3,
                FullName = $"Pelin KURT",
                City = $"Warsaw",
                Phone = $"09008008080",
                Email = GenerateRandomEmail($"Patient", "mvccms.com"),
                Password = "123123",
                DoctorId = 11
            };

            context.Patients.Add(patient);
            context.Patients.Add(patient2);
            context.Patients.Add(patient3);
            context.Patients.Add(patient4);
            context.Patients.Add(patient5);
            context.Patients.Add(patient6);
            context.Patients.Add(patient7);
            context.Patients.Add(patient8);
            context.Patients.Add(patient9);
            context.Patients.Add(patient10);
            context.Patients.Add(patient11);
            context.SaveChanges();
        }



        private static void SeedPosts(AppDbContext context)
        {

            var post = new Post
            {

                Title = "Advancements in Vision Care: The Opthomology Frontier",
                Image = "/Images/post.jpg",
                Content = "The field of opthomology continues to witness remarkable advancements that illuminate the path to clearer vision and healthier eyes. From innovative treatments for refractive errors to groundbreaking surgical interventions for complex eye conditions, the opthomology department stands at the forefront of visual well-being. Discover the journey of ophthalmologists as they employ cutting-edge technology, personalized care, and a commitment to excellence, ensuring that your eyesight remains a window to the world's wonders.",

            };

            var post2 = new Post
            {
                Image = "/Images/post2.jpg",
                Title = "Heartfelt Innovations: Navigating the Cardiology Horizon",
                Content = "The realm of cardiology pulsates with life-saving innovations that redefine heart health. Cardiologists harness the power of diagnostics and therapeutics to mend broken hearts and nurture healthy rhythms. Unveil the orchestration of electrocardiograms, echocardiograms, and surgical finesse as cardiologists mend the intricate symphony of the cardiovascular system. Step into a world where hearts find solace in precision, where advanced techniques are the heartbeat of a healthier future.",

            };
            var post3 = new Post
            {
                Image = "/Images/post3.jpg",
                Title = "Radiant Smiles: A Journey Through Dental Care Excellence",
                Content = "Dental care journeys beyond routine check-ups and teeth cleaning, weaving a tale of healthy smiles and oral well-being. Discover the artistry of dental care as dedicated dentists and hygienists sculpt brighter, healthier smiles. From cavities to gum health, delve into the meticulous craft of maintaining pearly whites. Unveil the secrets to maintaining oral hygiene, explore the realm of preventive measures, and uncover the gentle touch that keeps smiles glowing.",

            };
            var post4 = new Post
            {
                Image = "/Images/post4.jpg",
                Title = "Nurturing Blossoms: The Essence of Quality Child Care",
                Content = "Child care extends far beyond supervision, nurturing the growth of young minds with dedicated passion. Explore the heartwarming journey of caregivers and professionals who provide safe havens for blossoming souls. Delve into the world of child development, from early childhood to preschool, where every moment is a building block for the future. Join us in celebrating the magic of fostering joy, curiosity, and resilience in the youngest members of our community.",

            };
            var post5 = new Post
            {
                Image = "/Images/post5.jpg",
                Title = "Breathing Easy: Exploring Pulmonology's Respiratory Symphony",
                Content = "Pulmonology's realm is a testament to the human spirit's resilience, as specialists navigate the intricate pathways of the respiratory system. Journey alongside pulmonologists as they unravel the mysteries of lung health, from asthma's symphony to COPD's cadence. Peer into diagnostic harmonies and treatment orchestrations that breathe life into lungs and inspire breaths of vitality. Welcome to a world where each breath is cherished, and every sigh tells a story of hope.",

            };
            var post6 = new Post
            {
                Image = "/Images/post6.jpg",
                Title = "Empowering Women: Navigating the Path to Gynecological Well-Being",
                Content = "Gynecology transcends medical care, embracing the essence of womanhood and empowerment. Embark on a journey where specialized care meets holistic well-being, with gynecologists as guides through the intricate landscape of female health. Explore the spectrum of services, from routine wellness checks to personalized treatment plans. Witness the harmony of medical expertise and compassionate understanding, as gynecologists champion women's health at every life stage.",

            };
            var post7 = new Post
            {
                Image = "/Images/post7.jpg",
                Title = "Breathe Freely: Unveiling Allergy And Immunology's Healing Touch",
                Content = "In the realm of Allergy and Immunology, a symphony of care unfurls for those seeking solace from allergies and immunologic challenges. Discover the transformative journey of specialized care, where allergies find resolution and immunodeficiencies meet tailored solutions. Peer into a realm where the immune system's melodies are understood, and harmony is restored. Join us in celebrating lives unburdened by allergy's burden, where the immune system's resilience takes center stage.",

            };
            var post8 = new Post
            {
                Image = "/Images/post8.jpg",
                Title = "Nurturing Dreams: The Anesthesiology Canvas of Comfort",
                Content = "Anesthesiology is the guardian of peaceful slumber on the canvas of surgical endeavors. Step into a world where skilled anesthesiologists orchestrate tranquility, ensuring patients sail through the tides of surgery with serene dreams. Discover the artistry of anesthesia, where precise dosages and vigilant monitoring craft a journey of safety and comfort. Embrace the realm where sleep and healing intertwine, under the watchful gaze of anesthesiology's guardians.",

            };
            var post9 = new Post
            {
                Image = "/Images/post9.jpg",
                Title = "Taking Flight Safely: Navigating the Skies with Aviation Medical Services",
                Content = "In the world of aviation, health soars alongside dreams. Join us on a voyage where aviation professionals find their wings, courtesy of meticulous medical care. Explore the aviation medical examination process, where certified specialists ensure that pilots, cabin crew, and air traffic controllers navigate the skies in optimal health. Embark on a journey where health and safety dance hand in hand with the pursuit of the endless horizon.",

            };
            var post10 = new Post
            {
                Image = "/Images/post10.jpg",
                Title = "Surgical Symphony: Crafting Health and Healing through General Surgery",
                Content = "The General Surgery Department is a tapestry woven with the threads of healing, where skilled hands and cutting-edge techniques converge. Immerse yourself in the world of surgical expertise, where a spectrum of procedures mends and restores. From minimally invasive marvels to complex surgical symphonies, the general surgery journey is a testament to the artistry of healing. Join us in celebrating the stories etched on the canvas of patient well-being.",

            };
            var post11 = new Post
            {
                Image = "/Images/post11.jpg",
                Title = "Embracing Minds: Nurturing Mental Health through Psychiatry",
                Content = "Psychiatry is the realm where minds find solace and emotional well-being blooms. Dive into the world of psychiatry, where expert psychiatrists wield their medical mastery to illuminate the path to mental health. Uncover the art of listening, the science of understanding, and the compassion that nurtures resilience. Join us in celebrating the stories of transformation, where every step towards mental wellness is a triumph of the human spirit.",
            };



            context.Posts.Add(post);
            context.Posts.Add(post2);
            context.Posts.Add(post3);
            context.Posts.Add(post4);
            context.Posts.Add(post5);
            context.Posts.Add(post6);
            context.Posts.Add(post7);
            context.Posts.Add(post8);
            context.Posts.Add(post9);
            context.Posts.Add(post10);
            context.Posts.Add(post11);
            context.SaveChanges();
        }

        private static List<PostComment> SeedCommentsForPost(int postId)
        {
            var comments = new List<PostComment>();


            var comment = new PostComment
            {
                PostId = postId,
                Comment = $"Wow, these advancements in opthomology are simply astonishing! The strides made in eye care and vision enhancement are truly impressive. It's inspiring to witness how technology and medical expertise converge to illuminate the world for countless individuals. Kudos to the opthomology department for their dedication to preserving and restoring sight! {postId}",
                IsActive = true,
            };
            var comment2 = new PostComment
            {
                PostId = postId,
                Comment = $"The innovations in cardiology are nothing short of a lifesaver! Witnessing the fusion of science, compassion, and technology in heart care is awe-inspiring. Cardiologists truly hold the rhythm of life in their hands, mending hearts and paving the way for healthier tomorrows. A heartfelt salute to the cardiology department for their life-changing work! {postId}",
                IsActive = true,
            };
            var comment3 = new PostComment
            {
                PostId = postId,
                Comment = $"The world of dental care is beaming brighter than ever! It's fascinating to see how meticulous care and advanced techniques come together for healthier smiles. Dentists and hygienists are the unsung heroes of oral well-being, ensuring that every smile radiates with confidence. A big thank you to the dental care department for keeping our smiles shining! {postId}",
                IsActive = true,
            };
            var comment4 = new PostComment
            {
                PostId = postId,
                Comment = $"Child care is the nurturing heart of early development! Witnessing the dedication of caregivers and professionals in shaping young minds is heartwarming. Every child's laughter and curiosity are a testament to the loving care they receive. Kudos to the child care department for sowing the seeds of lifelong growth and happiness! {postId}",
                IsActive = true,
            };
            var comment5 = new PostComment
            {
                PostId = postId,
                Comment = $"The strides made in pulmonology breathe new life into respiratory health! The tireless efforts of pulmonologists in unraveling lung mysteries and restoring breath are truly commendable. Witnessing the impact of their expertise on respiratory wellness is a breath of fresh air. A standing ovation to the pulmonology department for nurturing the breath of life! {postId}",
                IsActive = true,
            };
            var comment6 = new PostComment
            {
                PostId = postId,
                Comment = $"Gynecology is a sanctuary of women's health and empowerment! The expertise and compassion of gynecologists shine brightly in their commitment to female well-being. Witnessing their impact on every stage of a woman's life is a celebration of resilience and vitality. A heartfelt salute to the gynecology department for championing women's health journeys! {postId}",
                IsActive = true,
            };
            var comment7 = new PostComment
            {
                PostId = postId,
                Comment = $"Allergy and Immunology, the heroes of immune resilience! Witnessing the relief brought to those battling allergies and immunologic challenges is heartening. The immune system's symphony finds harmony under their care, and lives are transformed. A standing ovation to the allergy and immunology department for restoring freedom from the burdens of immune response! {postId}",
                IsActive = true,
            };
            var comment8 = new PostComment
            {
                PostId = postId,
                Comment = $"Anesthesiology, the guardian of serenity in surgical journeys! Witnessing the expertise that ensures painless slumber during procedures is truly remarkable. Every surgery unfolds under their vigilant watch, fostering comfort and tranquility. A heartfelt thank you to the anesthesiology department for orchestrating peaceful healing slumber! {postId}",
                IsActive = true,
            };
            var comment9 = new PostComment
            {
                PostId = postId,
                Comment = $"Aviation Medical Services, the lifelines of safe flights! The dedication of specialized examiners in ensuring aviation professionals take to the skies in optimal health is commendable. Witnessing their role in maintaining skies safe and journeys smooth is awe-inspiring. A sky-high salute to the aviation medical services department for ensuring safe flights and endless horizons! {postId}",
                IsActive = true,
            };
            var comment10 = new PostComment
            {
                PostId = postId,
                Comment = $"General Surgery, the architects of healing journeys! Witnessing the skill and care that mend and restore is truly inspiring. From intricate surgeries to transformative interventions, every step is a testament to their commitment {postId}",
            IsActive = true,
            };
            var comment11 = new PostComment
            {
                PostId = postId,
                Comment = $"Psychiatry, the guardians of emotional well-being! Witnessing the impact of expert psychiatrists on mental health is truly heartening. Minds find solace and resilience under their care, paving the way for brighter tomorrows. A heartfelt applause to the psychiatry department for illuminating the path to mental wellness and emotional strength! {postId}",
                IsActive = true,
            };



            comments.Add(comment);
            comments.Add(comment2);
            comments.Add(comment3);
            comments.Add(comment4);
            comments.Add(comment5);
            comments.Add(comment6);
            comments.Add(comment7);
            comments.Add(comment8);
            comments.Add(comment9);
            comments.Add(comment10);
            comments.Add(comment11);
            return comments;
        }

        private static void SeedPostComments(AppDbContext context)
        {

            var postComment = new PostComment
            {
                PostId = 1, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
                UserId = 12, // Bu örnekte UserId'leri 1'den 10'a kadar ekledik.
                Comment = $"This is such a positive step forward in healthcare! The progress in genetic therapies and AI applications is truly impressive. It gives hope for better treatment options and faster diagnoses in the future. Kudos to all the researchers and healthcare professionals working tirelessly to make these advancements a reality!",
                IsActive = true, // Varsayılan olarak true olarak ekledik.
                                 // Gerekli diğer özellikleri de doldur.
            };
            var postComment2 = new PostComment
            {
                PostId = 2,
                UserId = 13,
                Comment = $"A leap forward in cardiac care! The advancements in genetics and AI applications hold immense promise for heart health. The dedication of researchers and healthcare experts shines brightly in these transformative steps. Here's to a future where hearts beat stronger and healthier, thanks to the cardiology department's unwavering efforts!",
                IsActive = true,
            };

            var postComment3 = new PostComment
            {
                PostId = 3,
                UserId = 14,
                Comment = $"A reason to smile brighter! The progress in dental care is a testament to the dedication of experts who nurture healthier teeth and gums. The fusion of science and compassion in oral well-being is truly commendable. Hats off to the dental care department for making every smile a masterpiece of health and confidence!",
                IsActive = true,
            };

            var postComment4 = new PostComment
            {
                PostId = 4,
                UserId = 15,
                Comment = $"A nurturing journey for young minds! Witnessing the impact of dedicated caregivers and professionals in child care is heartening. Every step towards childhood growth and development is a testament to the department's commitment. Here's to a future where children's laughter and curiosity flourish under the care of the child care department!",
                IsActive = true,
            };

            var postComment5 = new PostComment
            {
                PostId = 5,
                UserId = 16,
                Comment = $"Breathing new life into respiratory health! The advancements in pulmonology paint a picture of healthier lungs and improved well-being. Witnessing lives transformed through enhanced respiratory care is a tribute to the department's unwavering dedication. A heartfelt salute to the pulmonology team for helping us all breathe easier!",
                IsActive = true,
            };

            var postComment6 = new PostComment
            {
                PostId = 6,
                UserId = 17,
                Comment = $"A journey of women's wellness and empowerment! The strides made in gynecology reflect a commitment to female health and vitality. Witnessing lives transformed through expert care is a testament to the department's dedication. Here's to a future where every woman's health journey is nurtured with compassion and expertise!",
                IsActive = true,
            };

            var postComment7 = new PostComment
            {
                PostId = 7,
                UserId = 18,
                Comment = $"Unleashing the power of immunity! Witnessing the impact of allergy and immunology experts on immune resilience is truly inspiring. Lives transformed through relief from allergies and immune challenges are a tribute to the department's expertise. Here's to a future where immune health thrives under the care of the allergy and immunology department!",
                IsActive = true,
            };
            var postComment8 = new PostComment
            {
                PostId = 8,
                UserId = 19,
                Comment = $"Creating a tapestry of serene surgical journeys! The role of anesthesiology in painless procedures is truly remarkable. Witnessing surgeries unfold under peaceful slumber is a testament to the department's dedication. Here's to the anesthesiology team for orchestrating comfort and tranquility in healing journeys!",
                IsActive = true,
            }; 
            var postComment9 = new PostComment
            {
                PostId = 9,
                UserId = 20,
                Comment = $"Clear skies, safe flights! Witnessing the impact of aviation medical services on skyward journeys is awe-inspiring. The commitment to ensuring aviation professionals' health is a testament to expertise and dedication. Here's to the aviation medical services department for upholding safety in the skies!",
                IsActive = true,
            };
            var postComment10 = new PostComment
            {
                PostId = 10,
                UserId = 21,
                Comment = $"Architects of healing journeys! Witnessing the artistry of general surgery in restoring health is truly inspiring. Lives transformed through intricate procedures and skilled interventions reflect the dedication of the department. A heartfelt salute to the general surgery team for paving the way to healthier tomorrows!",
                IsActive = true,
            };
            var postComment11 = new PostComment
            {
                PostId = 11,
                UserId = 22,
                Comment = $"Nurturing minds, illuminating paths! Witnessing the impact of psychiatry on mental well-being is truly heartening. Lives transformed through expert care and compassionate support are a testament to the department's dedication. Here's to a future where every mind finds solace and resilience under the care of the psychiatry department!",
                IsActive = true,
            };






            context.PostComments.Add(postComment);
            context.PostComments.Add(postComment2);
            context.PostComments.Add(postComment3);
            context.PostComments.Add(postComment4);
            context.PostComments.Add(postComment5);
            context.PostComments.Add(postComment6);
            context.PostComments.Add(postComment7);
            context.PostComments.Add(postComment8);
            context.PostComments.Add(postComment9);
            context.PostComments.Add(postComment10);
            context.PostComments.Add(postComment11);


            context.SaveChanges();
        }

        private static void SeedRoles(AppDbContext context)
        {

            var role = new Role
            {
                RoleName = "Admin",
                // Gerekli diğer özellikleri de doldur.
            };
            var role2 = new Role
            {
                RoleName = "Doctor",
                // Gerekli diğer özellikleri de doldur.
            };
            var role3 = new Role
            {
                RoleName = "Patient",
                // Gerekli diğer özellikleri de doldur.
            };

            var role4 = new Role
            {
                RoleName = "User",
                // Gerekli diğer özellikleri de doldur.
            };

            var role5 = new Role
            {
                RoleName = "Guest",
                // Gerekli diğer özellikleri de doldur.
            };

            context.Roles.Add(role);
            context.Roles.Add(role2);
            context.Roles.Add(role3);
            context.Roles.Add(role4);
            context.Roles.Add(role5);
            context.SaveChanges();
        }

        private static void SeedSettings(AppDbContext context)
        {

            var setting = new Setting
            {
                Name = $"LifeSpringHospital",
                Address = $"Karaköy / İstanbul",
                Email = "academy@siliconmade.com",
                Image = "/Images/lifex.jpg",
                IsActive = true,
                Phone = "+90 850 272 7454",
                AlpLinkedin = "https://www.linkedin.com/in/alparslan-kobak-5a98831b5/",
                UtkuLinkedin = "https://www.youtube.com/shorts/fDjMVKTFjFs",
                KadirLinkedin = "https://www.linkedin.com/in/kadir-alt%C4%B1nay-919a66264/"
            };

            context.Settings.Add(setting);
            context.SaveChanges();
        }
        private static void SeedPages(AppDbContext context)
        {

            var page = new Page
            {
                Title = $"Cms News",
                Content = $"News From Healty World",
                IsActive = true, // Set IsActive based on your requirements.
                                 // Add other necessary properties here.
            };

            context.Pages.Add(page);

            var page2 = new Page
            {
                Title = $"Dr DEVRANI Advice To",
                Content = $"Care your health...",
                IsActive = true, // Set IsActive based on your requirements.
                                 // Add other necessary properties here.
            };

            context.Pages.Add(page2);

            var page3 = new Page
            {
                Title = $"Dr ALTINAY Advice To",
                Content = $"Most people do not really want freedom, because freedom involves responsibility, and most people are frightened of responsibility.",
                IsActive = true, // Set IsActive based on your requirements.
                                 // Add other necessary properties here.
            };

            context.Pages.Add(page3);

            var page4 = new Page
            {
                Title = $"Dr KOBAK Advice To",
                Content = $"Do you smoke? Eating junkie foods? Continue and relax... We need more patient...",
                IsActive = true, // Set IsActive based on your requirements.
                                 // Add other necessary properties here.
            };

            context.Pages.Add(page4);

            var page5 = new Page
            {
                Title = $"Dr KEMAL Advice To",
                Content = $"Just Fly, We can catch you...",
                IsActive = true, // Set IsActive based on your requirements.
                                 // Add other necessary properties here.
            };

            context.Pages.Add(page5);

            var page6 = new Page
            {
                Title = $"Dr BILSEL Advice To You",
                Content = $"If you wanna good chance in your life, Do not leave to chance on your teeth...",
                IsActive = true, // Set IsActive based on your requirements.
                                 // Add other necessary properties here.
            };

            context.Pages.Add(page6);
            context.SaveChanges();
        }

        private static void SeedUsers(AppDbContext context)
        {

            var user = new User
            {
                RoleId = 1, // Bu örnekte RoleId'leri 1'den 10'a kadar ekledik.
                            //  ImageId = i, // Bu örnekte ImageId'leri 1'den 10'a kadar ekledik.
                FullName = $"Admin admin",
                Image = "/Images/admin.jpg",
                Email = "admin@mvccms.com",
                Password = "123123",
                City = $"Istanbul",
                Phone = $"09008008080", // Örnek telefon numarası oluşturduk.
            };

            var user2 = new User
            {
                RoleId = 4, // Bu örnekte RoleId'leri 1'den 10'a kadar ekledik.
                            //  ImageId = i, // Bu örnekte ImageId'leri 1'den 10'a kadar ekledik.
                FullName = $"Guest",
                Email = GenerateRandomEmail($"User", "mvccms.com"),
                Password = "123123",
                City = $"Bagcilar",
                Phone = $"09008008080", // Örnek telefon numarası oluşturduk.
            };
            var user3 = new User
            {
                RoleId = 4, // Bu örnekte RoleId'leri 1'den 10'a kadar ekledik.
                            //  ImageId = i, // Bu örnekte ImageId'leri 1'den 10'a kadar ekledik.
                FullName = $"User",
                Email = GenerateRandomEmail($"User", "mvccms.com"),
                Password = "123123",
                City = $"Texas",
                Phone = $"09008008080", // Örnek telefon numarası oluşturduk.
            };

            context.Users.Add(user);
            context.Users.Add(user2);
            context.Users.Add(user3);
            context.SaveChanges();
        }
        private static void SeedDepartmentPosts(AppDbContext context)
        {

            var departmentPost = new DepartmentPost
            {
                DepartmentId = 1, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 1, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost2 = new DepartmentPost
            {
                DepartmentId = 2, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 2, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost3 = new DepartmentPost
            {
                DepartmentId = 3, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 3, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost4 = new DepartmentPost
            {
                DepartmentId = 4, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 4, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost5 = new DepartmentPost
            {
                DepartmentId = 5, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 5, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost6 = new DepartmentPost
            {
                DepartmentId = 6, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 6, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost7 = new DepartmentPost
            {
                DepartmentId = 7, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 7, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost8 = new DepartmentPost
            {
                DepartmentId = 8, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 8, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost9 = new DepartmentPost
            {
                DepartmentId = 9, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 9, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost10 = new DepartmentPost
            {
                DepartmentId = 10, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 10, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };
            var departmentPost11 = new DepartmentPost
            {
                DepartmentId = 11, // Bu örnekte DepartmentId'leri 1'den 10'a kadar ekledik.
                PostId = 11, // Bu örnekte PostId'leri 1'den 10'a kadar ekledik.
            };

            context.DepartmentPosts.Add(departmentPost);
            context.DepartmentPosts.Add(departmentPost2);
            context.DepartmentPosts.Add(departmentPost3);
            context.DepartmentPosts.Add(departmentPost4);
            context.DepartmentPosts.Add(departmentPost5);
            context.DepartmentPosts.Add(departmentPost6);
            context.DepartmentPosts.Add(departmentPost7);
            context.DepartmentPosts.Add(departmentPost8);
            context.DepartmentPosts.Add(departmentPost9);
            context.DepartmentPosts.Add(departmentPost10);
            context.DepartmentPosts.Add(departmentPost11);
            context.SaveChanges();
        }

        private static void SeedAppointments(AppDbContext context)
        {
            Appointment appointment = new()
            {
                DepartmentId = 2,
                DoctorId = 2,
                AppointmentDate = new DateTime(2023, 08, 17),
                Email = "lnt@coalminer.com",
                FullName = "Abuzer Coalsaler",
                Message = "My son gived me a toxic thing. Son of a Dog!",
                Phone = "974764233466",


            };
            context.Appointments.Add(appointment);

            Appointment appointment2 = new()
            {
                DepartmentId = 11,
                DoctorId = 3,
                AppointmentDate = new DateTime(2023, 08, 17),
                Email = "Kantarci@vadi.com",
                FullName = "Tuncay Weigher",
                Message = "I do not like bugs. Burn them all!",
                Phone = "974764233466",


            };
            context.Appointments.Add(appointment2);

            Appointment appointment3 = new()
            {
                DepartmentId = 9,
                DoctorId = 4,
                AppointmentDate = new DateTime(2023, 08, 17),
                Email = "Madman@guesthouse.com",
                FullName = "Unknown Guest",
                Message = "I do not know what i have...",
                Phone = "974764233466",


            };
            context.Appointments.Add(appointment3);

            Appointment appointment4 = new()
            {
                DepartmentId = 3,
                DoctorId = 5,
                AppointmentDate = new DateTime(2023, 08, 17),
                Email = "ChickGirl@gmail.com",
                FullName = "The Mediterranean Girl",
                Message = "I have nothing... But Dentist is too hot...",
                Phone = "974764233466",


            };
            context.Appointments.Add(appointment4);

            context.SaveChanges();
        }


        private static void SeedContacts(AppDbContext context)
        {
            Contact contact = new()
            {
                Title = "Non of Your Businness",
                Email = "chief@kgt.com",
                FullName = "Lion Whitelord",
                Message = "I gived you some stuffs. Take care of them!",
                Phone = "974764233466",


            };
            context.Contacts.Add(contact);




            context.SaveChanges();
        }

        private static void SeedSubscribber(AppDbContext context)
        {
            Subscriber subscribber = new()
            {

                Email = "Azrail2023@gmail.com"


            };
            context.Subscribbers.Add(subscribber);




            context.SaveChanges();
        }


        private static string GenerateRandomEmail(string name, string domain)
        {
            // Rastgele bir sayı ekleyerek benzersiz bir e-posta adresi oluşturun.
            var random = new Random();
            var randomNumber = random.Next(1000, 9999);
            return $"{name}{randomNumber}@{domain}";
        }
    }
}

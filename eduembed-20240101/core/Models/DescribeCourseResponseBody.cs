// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduEmbed20240101.Models
{
    public class DescribeCourseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Course")]
        [Validation(Required=false)]
        public DescribeCourseResponseBodyCourse Course { get; set; }
        public class DescribeCourseResponseBodyCourse : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Chapters")]
            [Validation(Required=false)]
            public List<DescribeCourseResponseBodyCourseChapters> Chapters { get; set; }
            public class DescribeCourseResponseBodyCourseChapters : TeaModel {
                [NameInMap("Lessons")]
                [Validation(Required=false)]
                public List<DescribeCourseResponseBodyCourseChaptersLessons> Lessons { get; set; }
                public class DescribeCourseResponseBodyCourseChaptersLessons : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public int? Number { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public List<DescribeCourseResponseBodyCourseChaptersUnit> Unit { get; set; }
                public class DescribeCourseResponseBodyCourseChaptersUnit : TeaModel {
                    [NameInMap("Lessons")]
                    [Validation(Required=false)]
                    public List<DescribeCourseResponseBodyCourseChaptersUnitLessons> Lessons { get; set; }
                    public class DescribeCourseResponseBodyCourseChaptersUnitLessons : TeaModel {
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public int? Duration { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public int? Number { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("LessonNum")]
            [Validation(Required=false)]
            public int? LessonNum { get; set; }

            [NameInMap("Lessons")]
            [Validation(Required=false)]
            public List<DescribeCourseResponseBodyCourseLessons> Lessons { get; set; }
            public class DescribeCourseResponseBodyCourseLessons : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("PictureUrl")]
            [Validation(Required=false)]
            public string PictureUrl { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

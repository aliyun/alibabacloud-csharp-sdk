// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduEmbed20240101.Models
{
    public class ListCoursesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Courses")]
        [Validation(Required=false)]
        public List<ListCoursesResponseBodyCourses> Courses { get; set; }
        public class ListCoursesResponseBodyCourses : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("LessonNum")]
            [Validation(Required=false)]
            public int? LessonNum { get; set; }

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

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

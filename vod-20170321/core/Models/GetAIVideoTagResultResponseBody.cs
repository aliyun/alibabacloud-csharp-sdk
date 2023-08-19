// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIVideoTagResultResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("VideoTagResult")]
        [Validation(Required=false)]
        public GetAIVideoTagResultResponseBodyVideoTagResult VideoTagResult { get; set; }
        public class GetAIVideoTagResultResponseBodyVideoTagResult : TeaModel {
            /// <summary>
            /// The video categories.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultCategory> Category { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultCategory : TeaModel {
                /// <summary>
                /// The tag string.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// The keyword tags.
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultKeyword> Keyword { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultKeyword : TeaModel {
                /// <summary>
                /// The tag string.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The points in time when the tags are displayed. Unit: milliseconds.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// The location tags.
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultLocation> Location { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultLocation : TeaModel {
                /// <summary>
                /// The tag string.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The points in time when the tags are displayed. Unit: milliseconds.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// The figure tags.
            /// </summary>
            [NameInMap("Person")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultPerson> Person { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultPerson : TeaModel {
                /// <summary>
                /// The URL of the profile photo.
                /// 
                /// > This parameter is returned only when a figure tag was used.
                /// </summary>
                [NameInMap("FaceUrl")]
                [Validation(Required=false)]
                public string FaceUrl { get; set; }

                /// <summary>
                /// The tag string.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The points in time when the tags are displayed. Unit: milliseconds.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// The time tags.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultTime> Time { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultTime : TeaModel {
                /// <summary>
                /// The tag string.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The points in time when the tags are displayed. Unit: milliseconds.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

        }

    }

}

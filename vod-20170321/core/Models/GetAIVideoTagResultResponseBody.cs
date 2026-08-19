// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIVideoTagResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8829B4DB-AFD9-4FF6-12965DBFFA14****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result data.</para>
        /// </summary>
        [NameInMap("VideoTagResult")]
        [Validation(Required=false)]
        public GetAIVideoTagResultResponseBodyVideoTagResult VideoTagResult { get; set; }
        public class GetAIVideoTagResultResponseBodyVideoTagResult : TeaModel {
            /// <summary>
            /// <para>The collection of video categories.</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultCategory> Category { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultCategory : TeaModel {
                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beauty</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The collection of keyword tags.</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultKeyword> Keyword { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultKeyword : TeaModel {
                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cushion</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The collection of time points. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The collection of location tags.</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultLocation> Location { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultLocation : TeaModel {
                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The collection of time points. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The collection of person tags.</para>
            /// </summary>
            [NameInMap("Person")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultPerson> Person { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultPerson : TeaModel {
                /// <summary>
                /// <para>The face URL.</para>
                /// <remarks>
                /// <para>This field is returned only for person tag results.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/aivideotag/8829B4DB-AFD9-4F*****F6-12965DBFFA14/Index_****.jpg">http://example.com/aivideotag/8829B4DB-AFD9-4F*****F6-12965DBFFA14/Index_****.jpg</a></para>
                /// </summary>
                [NameInMap("FaceUrl")]
                [Validation(Required=false)]
                public string FaceUrl { get; set; }

                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Xiao Wang</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The collection of time points. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The collection of time tags.</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultTime> Time { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultTime : TeaModel {
                /// <summary>
                /// <para>The label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Millisecond</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The collection of time points. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIVideoTagResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8829B4DB-AFD9-4FF6-12965DBFFA14****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("VideoTagResult")]
        [Validation(Required=false)]
        public GetAIVideoTagResultResponseBodyVideoTagResult VideoTagResult { get; set; }
        public class GetAIVideoTagResultResponseBodyVideoTagResult : TeaModel {
            /// <summary>
            /// <para>The video categories.</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultCategory> Category { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultCategory : TeaModel {
                /// <summary>
                /// <para>The tag string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Retouching</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The keyword tags.</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultKeyword> Keyword { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultKeyword : TeaModel {
                /// <summary>
                /// <para>The tag string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cushion</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The points in time when the tags are displayed. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The location tags.</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultLocation> Location { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultLocation : TeaModel {
                /// <summary>
                /// <para>The tag string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The points in time when the tags are displayed. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The figure tags.</para>
            /// </summary>
            [NameInMap("Person")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultPerson> Person { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultPerson : TeaModel {
                /// <summary>
                /// <para>The URL of the profile photo.</para>
                /// <remarks>
                /// <para>This parameter is returned only when a figure tag was used.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/aivideotag/8829B4DB-AFD9-4F*****F6-12965DBFFA14/Index_****.jpg">http://example.com/aivideotag/8829B4DB-AFD9-4F*****F6-12965DBFFA14/Index_****.jpg</a></para>
                /// </summary>
                [NameInMap("FaceUrl")]
                [Validation(Required=false)]
                public string FaceUrl { get; set; }

                /// <summary>
                /// <para>The tag string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The points in time when the tags are displayed. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

            /// <summary>
            /// <para>The time tags.</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public List<GetAIVideoTagResultResponseBodyVideoTagResultTime> Time { get; set; }
            public class GetAIVideoTagResultResponseBodyVideoTagResultTime : TeaModel {
                /// <summary>
                /// <para>The tag string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Milliseconds</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The points in time when the tags are displayed. Unit: milliseconds.</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public List<string> Times { get; set; }

            }

        }

    }

}

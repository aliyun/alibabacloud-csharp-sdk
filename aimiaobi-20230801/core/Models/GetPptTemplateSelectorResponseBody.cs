// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetPptTemplateSelectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPptTemplateSelectorResponseBodyData Data { get; set; }
        public class GetPptTemplateSelectorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The careers.</para>
            /// </summary>
            [NameInMap("Career")]
            [Validation(Required=false)]
            public List<GetPptTemplateSelectorResponseBodyDataCareer> Career { get; set; }
            public class GetPptTemplateSelectorResponseBodyDataCareer : TeaModel {
                /// <summary>
                /// <para>The career ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the career is popular.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsHot")]
                [Validation(Required=false)]
                public long? IsHot { get; set; }

                /// <summary>
                /// <para>The career name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>教育培训</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The colors.</para>
            /// </summary>
            [NameInMap("Colour")]
            [Validation(Required=false)]
            public List<GetPptTemplateSelectorResponseBodyDataColour> Colour { get; set; }
            public class GetPptTemplateSelectorResponseBodyDataColour : TeaModel {
                /// <summary>
                /// <para>The color value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>#FCC462</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The color ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The color name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>橙色</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The scenarios.</para>
            /// </summary>
            [NameInMap("SuitScene")]
            [Validation(Required=false)]
            public List<GetPptTemplateSelectorResponseBodyDataSuitScene> SuitScene { get; set; }
            public class GetPptTemplateSelectorResponseBodyDataSuitScene : TeaModel {
                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The scenario name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>教育培训</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The styles.</para>
            /// </summary>
            [NameInMap("SuitStyle")]
            [Validation(Required=false)]
            public List<GetPptTemplateSelectorResponseBodyDataSuitStyle> SuitStyle { get; set; }
            public class GetPptTemplateSelectorResponseBodyDataSuitStyle : TeaModel {
                /// <summary>
                /// <para>The style ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The style name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>扁平简约</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>错误消息</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

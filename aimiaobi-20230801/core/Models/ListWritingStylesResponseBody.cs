// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListWritingStylesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of writing styles.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWritingStylesResponseBodyData> Data { get; set; }
        public class ListWritingStylesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The template definition for step-by-step writing.</para>
            /// </summary>
            [NameInMap("DistributeStepTemplateDefine")]
            [Validation(Required=false)]
            public WritingStyleTemplateDefine DistributeStepTemplateDefine { get; set; }

            /// <summary>
            /// <para>Indicates whether step-by-step writing is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DistributeWriting")]
            [Validation(Required=false)]
            public bool? DistributeWriting { get; set; }

            /// <summary>
            /// <para>The icon for the writing style, represented by a character.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小图标</para>
            /// </summary>
            [NameInMap("Emoji")]
            [Validation(Required=false)]
            public string Emoji { get; set; }

            /// <summary>
            /// <para>The description of the writing style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文体描述</para>
            /// </summary>
            [NameInMap("StyleDescription")]
            [Validation(Required=false)]
            public string StyleDescription { get; set; }

            /// <summary>
            /// <para>The image for the writing style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文体图片</para>
            /// </summary>
            [NameInMap("StyleImage")]
            [Validation(Required=false)]
            public string StyleImage { get; set; }

            /// <summary>
            /// <para>The unique key of the writing style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文体唯一标识</para>
            /// </summary>
            [NameInMap("StyleKey")]
            [Validation(Required=false)]
            public string StyleKey { get; set; }

            /// <summary>
            /// <para>The name of the writing style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>文体名称</para>
            /// </summary>
            [NameInMap("StyleName")]
            [Validation(Required=false)]
            public string StyleName { get; set; }

            /// <summary>
            /// <para>The template definition for the writing style.</para>
            /// </summary>
            [NameInMap("TemplateDefine")]
            [Validation(Required=false)]
            public WritingStyleTemplateDefine TemplateDefine { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>数据不存在</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The next token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>下一页token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

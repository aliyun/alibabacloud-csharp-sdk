// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListWritingStylesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWritingStylesResponseBodyData> Data { get; set; }
        public class ListWritingStylesResponseBodyData : TeaModel {
            [NameInMap("DistributeStepTemplateDefine")]
            [Validation(Required=false)]
            public WritingStyleTemplateDefine DistributeStepTemplateDefine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DistributeWriting")]
            [Validation(Required=false)]
            public bool? DistributeWriting { get; set; }

            [NameInMap("Emoji")]
            [Validation(Required=false)]
            public string Emoji { get; set; }

            [NameInMap("StyleDescription")]
            [Validation(Required=false)]
            public string StyleDescription { get; set; }

            [NameInMap("StyleImage")]
            [Validation(Required=false)]
            public string StyleImage { get; set; }

            [NameInMap("StyleKey")]
            [Validation(Required=false)]
            public string StyleKey { get; set; }

            [NameInMap("StyleName")]
            [Validation(Required=false)]
            public string StyleName { get; set; }

            [NameInMap("TemplateDefine")]
            [Validation(Required=false)]
            public WritingStyleTemplateDefine TemplateDefine { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

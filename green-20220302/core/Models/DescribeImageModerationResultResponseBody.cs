// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This is the same as the HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The results of the image content moderation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageModerationResultResponseBodyData Data { get; set; }
        public class DescribeImageModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccountId specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The value of the \<c>dataId\\</c> parameter specified in the API request. This field is not returned if \<c>dataId\\</c> was not specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a5389eb-4ff8-4584-ac99-644e2a539aa1</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>Information about the image frames.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;result&quot;:[{&quot;confidence&quot;:81.22,&quot;label&quot;:&quot;violent_explosion&quot;}]}]</para>
            /// </summary>
            [NameInMap("Frame")]
            [Validation(Required=false)]
            public string Frame { get; set; }

            /// <summary>
            /// <para>The number of result frames.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FrameNum")]
            [Validation(Required=false)]
            public int? FrameNum { get; set; }

            /// <summary>
            /// <para>The ID of the manual review task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx-xxxxx</para>
            /// </summary>
            [NameInMap("ManualTaskId")]
            [Validation(Required=false)]
            public string ManualTaskId { get; set; }

            /// <summary>
            /// <para>The \<c>ReqId\\</c> returned by the asynchronous Image Moderation Pro API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B0963D30-BAB4-562F-9ED0-7A23AEC51C7C</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// <para>The results of the image moderation, including risk labels and confidence scores.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeImageModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeImageModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The confidence score. The value ranges from 0 to 100. The value is accurate to two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未检测出风险</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label returned after the image content is moderated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

            }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Alibaba Cloud generates this ID for each request. Use this ID to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2881AD4F-638B-52A3-BA20-F74C5B1CEAE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

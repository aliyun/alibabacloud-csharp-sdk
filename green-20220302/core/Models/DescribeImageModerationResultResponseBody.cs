// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageModerationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The image moderation results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageModerationResultResponseBodyData Data { get; set; }
        public class DescribeImageModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The value of dataId that is specified in the API request. If this parameter is not specified in the API request, this field is not available in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a5389eb-4ff8-4584-ac99-644e2a539aa1</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The information about the captured frames.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;result&quot;:[{&quot;confidence&quot;:81.22,&quot;label&quot;:&quot;violent_explosion&quot;}]}]</para>
            /// </summary>
            [NameInMap("Frame")]
            [Validation(Required=false)]
            public string Frame { get; set; }

            /// <summary>
            /// <para>The number of frames.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FrameNum")]
            [Validation(Required=false)]
            public int? FrameNum { get; set; }

            /// <summary>
            /// <para>The reqId field returned by the Image Async Moderation API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B0963D30-BAB4-562F-9ED0-7A23AEC51C7C</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// <para>The results of image moderation parameters such as the label parameter and the confidence parameter.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeImageModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeImageModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The description of the result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no risk</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The labels returned after the image moderation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>Risk Level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2881AD4F-638B-52A3-BA20-F74C5B1CEAE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

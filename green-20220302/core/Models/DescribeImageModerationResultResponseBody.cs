// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageModerationResultResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The image moderation results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageModerationResultResponseBodyData Data { get; set; }
        public class DescribeImageModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// The value of dataId that is specified in the API request. If this parameter is not specified in the API request, this field is not available in the response.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// The information about the captured frames.
            /// </summary>
            [NameInMap("Frame")]
            [Validation(Required=false)]
            public string Frame { get; set; }

            /// <summary>
            /// The number of frames.
            /// </summary>
            [NameInMap("FrameNum")]
            [Validation(Required=false)]
            public int? FrameNum { get; set; }

            /// <summary>
            /// The reqId field returned by the Image Async Moderation API.
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// The results of image moderation parameters such as the label parameter and the confidence parameter.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeImageModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeImageModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// The description of the result.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The labels returned after the image moderation.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// Risk Level.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// The message that is returned in response to the request.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The request ID, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

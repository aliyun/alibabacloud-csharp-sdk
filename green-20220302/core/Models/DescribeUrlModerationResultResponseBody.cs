// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUrlModerationResultResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUrlModerationResultResponseBodyData Data { get; set; }
        public class DescribeUrlModerationResultResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the moderated object.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// Supplementary information.
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeUrlModerationResultResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// ICP record number.
                /// </summary>
                [NameInMap("IcpNo")]
                [Validation(Required=false)]
                public string IcpNo { get; set; }

                /// <summary>
                /// ICP filing type.
                /// </summary>
                [NameInMap("IcpType")]
                [Validation(Required=false)]
                public string IcpType { get; set; }

                [NameInMap("SiteType")]
                [Validation(Required=false)]
                public string SiteType { get; set; }

            }

            /// <summary>
            /// The reqId field returned by the Url Async Moderation API.
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// The results of url async moderation parameters such as the label parameter and the confidence parameter.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeUrlModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places. Some labels do not have scores of confidence levels.
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// The labels returned after the url async moderation.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned in response to the request.
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

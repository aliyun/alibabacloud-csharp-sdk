// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUrlModerationResultResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The status code 200 indicates that the request was successful.
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
            /// The value of dataId that is specified in the API request. If this parameter is not specified in the API request, this field is not available in the response.
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// The supplementary information.
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeUrlModerationResultResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// The ICP number.
                /// </summary>
                [NameInMap("IcpNo")]
                [Validation(Required=false)]
                public string IcpNo { get; set; }

                /// <summary>
                /// The type of the ICP filing.
                /// </summary>
                [NameInMap("IcpType")]
                [Validation(Required=false)]
                public string IcpType { get; set; }

                /// <summary>
                /// The type of site
                /// </summary>
                [NameInMap("SiteType")]
                [Validation(Required=false)]
                public string SiteType { get; set; }

            }

            /// <summary>
            /// The ReqId field returned by an asynchronous URL moderation operation.
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// The returned results.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeUrlModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The score of the confidence level. Valid values: 0 to 100. The value is accurate to two decimal places.
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// The labels returned after the asynchronous URL moderation.
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

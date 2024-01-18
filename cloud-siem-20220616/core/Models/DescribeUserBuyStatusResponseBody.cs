// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeUserBuyStatusResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserBuyStatusResponseBodyData Data { get; set; }
        public class DescribeUserBuyStatusResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the logon Alibaba Cloud account can be used to place orders for the threat analysis feature, such as purchase, upgrade, and specifications change orders. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("CanBuy")]
            [Validation(Required=false)]
            public bool? CanBuy { get; set; }

            /// <summary>
            /// The log storage capacity that is purchased for the threat analysis feature. Unit: GB.
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            /// <summary>
            /// The number of days before the expiration time of the threat analysis feature.
            /// </summary>
            [NameInMap("DurationDays")]
            [Validation(Required=false)]
            public long? DurationDays { get; set; }

            /// <summary>
            /// The timestamp when the threat analysis feature expires. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// The username of the Alibaba Cloud account that is used to purchase the threat analysis feature.
            /// </summary>
            [NameInMap("MainUserName")]
            [Validation(Required=false)]
            public string MainUserName { get; set; }

            /// <summary>
            /// The ID of the management account of the resource directory.
            /// </summary>
            [NameInMap("MasterUserId")]
            [Validation(Required=false)]
            public long? MasterUserId { get; set; }

            /// <summary>
            /// The display name of the management account of the resource directory.
            /// </summary>
            [NameInMap("MasterUserName")]
            [Validation(Required=false)]
            public string MasterUserName { get; set; }

            /// <summary>
            /// The instance ID of Security Center.
            /// </summary>
            [NameInMap("SasInstanceId")]
            [Validation(Required=false)]
            public string SasInstanceId { get; set; }

            /// <summary>
            /// The ID of the logon Alibaba Cloud account.
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// The username of the logon Alibaba Cloud account.
            /// </summary>
            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

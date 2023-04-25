// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetQuotaTipResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional message. This message is typically used to describe API call failures for troubleshooting.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The quota.
        /// </summary>
        [NameInMap("QuotaData")]
        [Validation(Required=false)]
        public GetQuotaTipResponseBodyQuotaData QuotaData { get; set; }
        public class GetQuotaTipResponseBodyQuotaData : TeaModel {
            /// <summary>
            /// The number of available groups.
            /// </summary>
            [NameInMap("GroupLeft")]
            [Validation(Required=false)]
            public int? GroupLeft { get; set; }

            /// <summary>
            /// The number of used groups.
            /// </summary>
            [NameInMap("GroupUsed")]
            [Validation(Required=false)]
            public int? GroupUsed { get; set; }

            /// <summary>
            /// The method that you use to purchase partitions. Valid values:
            /// 
            /// *   0: indicates that the instance is purchased based on topics.
            /// *   1: indicates that the instance is purchased based on partitions.
            /// </summary>
            [NameInMap("IsPartitionBuy")]
            [Validation(Required=false)]
            public int? IsPartitionBuy { get; set; }

            /// <summary>
            /// The number of available partitions.
            /// </summary>
            [NameInMap("PartitionLeft")]
            [Validation(Required=false)]
            public int? PartitionLeft { get; set; }

            /// <summary>
            /// The number of purchased partitions.
            /// </summary>
            [NameInMap("PartitionNumOfBuy")]
            [Validation(Required=false)]
            public int? PartitionNumOfBuy { get; set; }

            /// <summary>
            /// The quota of partitions.
            /// </summary>
            [NameInMap("PartitionQuota")]
            [Validation(Required=false)]
            public int? PartitionQuota { get; set; }

            /// <summary>
            /// The number of used partitions.
            /// </summary>
            [NameInMap("PartitionUsed")]
            [Validation(Required=false)]
            public int? PartitionUsed { get; set; }

            /// <summary>
            /// The number of available topics.
            /// </summary>
            [NameInMap("TopicLeft")]
            [Validation(Required=false)]
            public int? TopicLeft { get; set; }

            /// <summary>
            /// The number of purchased topics.
            /// </summary>
            [NameInMap("TopicNumOfBuy")]
            [Validation(Required=false)]
            public int? TopicNumOfBuy { get; set; }

            /// <summary>
            /// The quota of topics.
            /// </summary>
            [NameInMap("TopicQuota")]
            [Validation(Required=false)]
            public int? TopicQuota { get; set; }

            /// <summary>
            /// The number of used topics.
            /// </summary>
            [NameInMap("TopicUsed")]
            [Validation(Required=false)]
            public int? TopicUsed { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

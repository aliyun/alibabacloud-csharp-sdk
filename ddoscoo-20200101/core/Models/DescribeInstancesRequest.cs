// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstancesRequest : TeaModel {
        /// <summary>
        /// The mitigation plan of the instance to query. Valid values:
        /// 
        /// *   **0**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan
        /// *   **1**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan
        /// *   **2**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Chinese Mainland Acceleration (CMA) mitigation plan
        /// *   **9**: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public int? Edition { get; set; }

        /// <summary>
        /// The traffic forwarding status of the instance to query. Valid values:
        /// 
        /// *   **0**: The instance no longer forwards service traffic.
        /// *   **1**: The instance forwards service traffic as expected.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public int? Enabled { get; set; }

        /// <summary>
        /// The end of the time range to query. Instances whose expiration time is earlier than the point in time are queried. This value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("ExpireEndTime")]
        [Validation(Required=false)]
        public long? ExpireEndTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Instances whose expiration time is later than the point in time are queried. This value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("ExpireStartTime")]
        [Validation(Required=false)]
        public long? ExpireStartTime { get; set; }

        /// <summary>
        /// The IDs of the instances to query. You can specify up to 200 instance IDs.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The IP address of the instance to query.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The remarks of the instance to query. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The states of the instances to query. You can specify up to two states.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<int?> Status { get; set; }

        /// <summary>
        /// The tags that are added to the instances to query.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the instance to query. You can specify up to 200 tag keys. When you specify tags, take note of the following rules:
            /// 
            /// *   Each tag consists of a key (**Key**) and a value (**Value**), which are separated with a comma (,).
            /// *   Separate multiple tags with commas (,).
            /// 
            /// >  The tag key (**Key**) and tag value (**Value**) must be specified in pairs.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the instance to query. You can specify up to 200 tag values. When you specify tags, take note of the following rules:
            /// 
            /// *   Each tag consists of a key (**Key**) and a value (**Value**), which are separated with a comma (,).
            /// *   Separate multiple tags with commas (,).
            /// 
            /// >  The tag key (**Key**) and tag value (**Value**) must be specified in pairs.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

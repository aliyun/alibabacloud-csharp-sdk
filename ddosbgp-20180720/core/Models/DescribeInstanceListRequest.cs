// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListRequest : TeaModel {
        /// <summary>
        /// The IDs of the Anti-DDoS Origin instances to query. Specify the value is in the `["<Instance ID 1>","<Instance ID 2>",……]` format.
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public string InstanceIdList { get; set; }

        /// <summary>
        /// The mitigation plan of the Anti-DDoS Origin instance to query. Valid values:
        /// 
        /// *   **0**: the Professional mitigation plan
        /// *   **1**: the Enterprise mitigation plan
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        /// <summary>
        /// The IP address of the object that is protected by the Anti-DDoS Origin instance to query.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The protocol type of the IP address asset that is protected by the Anti-DDoS Origin instance to query. Valid values:
        /// 
        /// *   **Ipv4**: IPv4
        /// *   **Ipv6**: IPv6
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The field that is used to sort the Anti-DDoS Origin instances. Set the value to **expireTime**, which indicates that the instances are sorted based on the expiration time.
        /// 
        /// You can set the **Orderdire** parameter to specify the sorting method.
        /// </summary>
        [NameInMap("Orderby")]
        [Validation(Required=false)]
        public string Orderby { get; set; }

        /// <summary>
        /// The sorting method. Valid values:
        /// 
        /// *   **desc**: the descending order. This is the default value.
        /// *   **asc**: the ascending order.
        /// </summary>
        [NameInMap("Orderdire")]
        [Validation(Required=false)]
        public string Orderdire { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the Anti-DDoS Origin instance to query resides.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The remarks of the Anti-DDoS Origin instance to query. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstanceListRequestTag> Tag { get; set; }
        public class DescribeInstanceListRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the Anti-DDoS Origin instance to query.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the Anti-DDoS Origin instance to query.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstancesResponseBody : TeaModel {
        /// <summary>
        /// The list of queried instances.
        /// </summary>
        [NameInMap("GtmInstances")]
        [Validation(Required=false)]
        public DescribeGtmInstancesResponseBodyGtmInstances GtmInstances { get; set; }
        public class DescribeGtmInstancesResponseBodyGtmInstances : TeaModel {
            [NameInMap("GtmInstance")]
            [Validation(Required=false)]
            public List<DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance> GtmInstance { get; set; }
            public class DescribeGtmInstancesResponseBodyGtmInstancesGtmInstance : TeaModel {
                /// <summary>
                /// The number of access policies.
                /// </summary>
                [NameInMap("AccessStrategyNum")]
                [Validation(Required=false)]
                public int? AccessStrategyNum { get; set; }

                /// <summary>
                /// The number of address pools.
                /// </summary>
                [NameInMap("AddressPoolNum")]
                [Validation(Required=false)]
                public int? AddressPoolNum { get; set; }

                /// <summary>
                /// The name of the alert group.
                /// </summary>
                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public string AlertGroup { get; set; }

                /// <summary>
                /// The CNAME domain name that is used to access the instance.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The CNAME domain name used to access the instance. Valid values:
                /// 
                /// *   **SYSTEM_ASSIGN**: A CNAME domain name assigned by the system is used.
                /// *   **CUSTOM**: A custom CNAME domain name is used.
                /// </summary>
                [NameInMap("CnameMode")]
                [Validation(Required=false)]
                public string CnameMode { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates when the instance was created.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The time when the instance expires.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The UNIX timestamp that indicates when the instance expires.
                /// </summary>
                [NameInMap("ExpireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The load balancing policy that is used. Valid values:
                /// 
                /// *   **ALL_RR**: Load balancing
                /// *   **RATIO**: Weighted round-robin
                /// </summary>
                [NameInMap("LbaStrategy")]
                [Validation(Required=false)]
                public string LbaStrategy { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The global time to live (TTL).
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// The domain name of the user.
                /// </summary>
                [NameInMap("UserDomainName")]
                [Validation(Required=false)]
                public string UserDomainName { get; set; }

                /// <summary>
                /// The version code of the instance.
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

        }

        /// <summary>
        /// The returned page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

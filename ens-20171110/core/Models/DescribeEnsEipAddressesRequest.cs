// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesRequest : TeaModel {
        /// <summary>
        /// The ID of the EIP that you want to query. You can specify up to 50 EIP IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// The ID of the instance with which you want to associate the EIP.
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// The type of the instance with which you want to associate the EIP. Valid values:
        /// 
        /// *   **EnsInstance**: ENS instance in a VPC
        /// *   **SlbInstance**: Edge Load Balancer (ELB) instance
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// The EIP that you want to query. You can specify up to 50 EIPs. Separate multiple EIPs with commas (,).
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public string EipAddress { get; set; }

        /// <summary>
        /// The name of the EIP.
        /// </summary>
        [NameInMap("EipName")]
        [Validation(Required=false)]
        public string EipName { get; set; }

        /// <summary>
        /// The ID of the Edge Node Service (ENS) node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the EIP is a secondary EIP. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Standby")]
        [Validation(Required=false)]
        public string Standby { get; set; }

    }

}

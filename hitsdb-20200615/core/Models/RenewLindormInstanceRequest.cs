// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class RenewLindormInstanceRequest : TeaModel {
        /// <summary>
        /// The subscription duration of the instance. The valid values of this parameter depend on the value of the PricingCycle parameter.
        /// 
        /// *   If PricingCycle is set to **Month**, set this parameter to an integer that ranges from **1** to **9**.
        /// *   If PricingCycle is set to **Year**, set this parameter to an integer that ranges from **1** to **3**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The ID of the instance that you want to renew. You can call the [GetLindormInstanceList](~~426069~~) operation to obtain the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The period based on which you are charged for the instance. Valid values:
        /// 
        /// *   **Month**: You are charged for the instance based on months.
        /// *   **Year**: You are charged for the instance based on years.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the region in which the instance that you want to renew is located. You can call the [DescribeRegions](~~426062~~) operation to query the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

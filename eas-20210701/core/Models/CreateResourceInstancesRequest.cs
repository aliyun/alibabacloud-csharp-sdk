// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceInstancesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   false (default)
        /// *   true
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   PrePaid: subscription.
        /// *   PostPaid: pay-as-you-go.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The number of instances that you want to create. Valid values: 1 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EcsInstanceCount")]
        [Validation(Required=false)]
        public int? EcsInstanceCount { get; set; }

        /// <summary>
        /// The type of the Elastic Compute Service (ECS) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EcsInstanceType")]
        [Validation(Required=false)]
        public string EcsInstanceType { get; set; }

        /// <summary>
        /// The size of the system disk. Unit: GiB. Valid values: 200 to 2000. Default value: 200.
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// The user-defined information. This parameter is not in use.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// The zone to which the instance belongs.
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}

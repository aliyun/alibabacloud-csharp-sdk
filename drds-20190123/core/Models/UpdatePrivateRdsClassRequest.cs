// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class UpdatePrivateRdsClassRequest : TeaModel {
        /// <summary>
        /// Specifies whether to use vouchers to offset the purchase fees. Valid values: **true** and **false**. Default value: false.
        /// 
        /// > If you downgrade the specifications of an instance after you use the vouchers, the vouchers used for the purchase cannot be refunded.
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// The ID of the custom ApsaraDB RDS instance at the storage layer.
        /// 
        /// > You can call the [DescribeDrdsRdsInstances](~~xxxx~~) operation to query the details of all ApsaraDB RDS instances at the storage layer of a PolarDB-X 1.0 instance, including the IDs of the ApsaraDB RDS instances.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// 
        /// > You can call the [DescribeDrdsInstances](~~139284~~) operation to query the details of all PolarDB-X 1.0 instances within an Alibaba Cloud account, including the IDs of the instances.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// This parameter is discontinued.
        /// </summary>
        [NameInMap("PrePayDuration")]
        [Validation(Required=false)]
        public int? PrePayDuration { get; set; }

        /// <summary>
        /// The new instance type of the custom ApsaraDB RDS instance at the storage layer.
        /// 
        /// > You can call the [DescribeAvailableClasses](~~196546~~) operation to view the specifications that are supported for a custom ApsaraDB RDS instance. The specifications include the instance type and the storage capacity.
        /// </summary>
        [NameInMap("RdsClass")]
        [Validation(Required=false)]
        public string RdsClass { get; set; }

        /// <summary>
        /// The new storage capacity of the custom ApsaraDB RDS instance at the storage layer.
        /// 
        /// > You can call the [DescribeAvailableClasses](~~196546~~) operation to view the specifications that are supported for a custom ApsaraDB RDS instance. The specifications include the instance type and the storage capacity.
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

    }

}

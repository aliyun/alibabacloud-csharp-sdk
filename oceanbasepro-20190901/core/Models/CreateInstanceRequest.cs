// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic renewal.   
        /// This parameter is valid only when the ChargeType parameter is set to PrePaid. Valid values: 
        /// - true: enables automatic renewal for the instance.   
        /// - false: disables automatic renewal for the instance. This is the default value.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The automatic renewal period of the instance. This parameter is required when the AutoRenew parameter is set to true. Valid values:  
        /// - If the PeriodUnit parameter is set to Year: "1", "2", and "3".   
        /// - If the PeriodUnit parameter is set to Month: "1", "2", "3", "6", and "12".
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public long? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:  
        /// - PrePay: the subscription billing method. You must ensure that the remaining balance or credit balance of your account can cover the cost of the subscription. Otherwise, you will receive an InvalidPayMethod error. 
        /// - PostPay: the pay-as-you-go billing method. This is the default value. By default, fees are charged on an hourly basis.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The size of the storage space,in GB.    
        /// The limits on the storage space vary with the cluster specifications:   
        /// - 8C32GB: 100 GB to 10000 GB   
        /// - 14C70GB: 200 GB to 10000 GB   
        /// - 30C180GB: 400 GB to 10000 GB   
        /// - 62C400GB: 800 GB to 10000 GB    
        /// The preceding minimum storage space sizes are the default storage space sizes of the corresponding cluster specification plans.
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public long? DiskSize { get; set; }

        /// <summary>
        /// The return result of the request.
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// The specifications of the cluster.     
        /// You can specify one of the following four plans:   
        ///  - 8C32GB: indicates 8 CPU cores and 32 GB of memory.    
        ///  - 14C70GB: indicates 14 CPU cores and 70 GB of memory. This is the default value.
        /// - 30C180GB: indicates 30 CPU cores and 180 GB of memory.     
        /// - 62C400GB: indicates 62 CPU cores and 400 GB of memory.
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The name of the OceanBase cluster.    
        /// It must be 1 to 20 characters in length.   
        /// If this parameter is not specified, the value is the instance ID of the cluster by default.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// OceanBase Server version number.
        /// </summary>
        [NameInMap("ObVersion")]
        [Validation(Required=false)]
        public string ObVersion { get; set; }

        /// <summary>
        /// The valid duration of the purchased resources. The unit is specified by the PeriodUnit parameter.   
        /// This parameter is valid and required only when the InstanceChargeType parameter is set to PrePaid.      
        /// Valid values:     
        /// - When the PeriodUnit parameter is set to Month: "1", "2", "3", "4", "5", "6", "7", "8", "9". 
        /// - When the PeriodUnit parameter is set to Year: "1", "2", "3".
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The unit of the valid duration of the purchased resources.     
        /// Valid value for subscription: Month or Year.
        /// Default value: Month for subscription, and Hour for pay-as-you-go.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The series of the OceanBase cluster. Valid values:    
        /// - normal: Standard Cluster Edition (Cloud Disk). This is the default value.
        /// - normal_ssd: Standard Cluster Edition (Local Disk).
        /// - history: History Database Cluster Edition.
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// The ID of the zone to which the instance belongs.   
        /// For more information about how to obtain the list of zones, see [DescribeZones](~~25610~~).
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public string Zones { get; set; }

    }

}

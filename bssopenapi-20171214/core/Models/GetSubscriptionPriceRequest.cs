// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetSubscriptionPriceRequest : TeaModel {
        /// <summary>
        /// The ID of the instance for which the price is queried. This parameter is required if you upgrade an instance. You can specify this parameter to obtain the pre-upgrade configurations of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The information about the pricing module.
        /// </summary>
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public List<GetSubscriptionPriceRequestModuleList> ModuleList { get; set; }
        public class GetSubscriptionPriceRequestModuleList : TeaModel {
            /// <summary>
            /// The configurations of the Nth pricing module. Valid values of N: 1 to 50. Format: AA:aa,BB:bb. The values of AA and BB are the property IDs of the pricing module. The values of aa and bb are the property values of the pricing module.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The identifier of the Nth pricing module.
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// The status of the pricing module. This parameter is required only if the order type is Upgrade. Valid values:
            /// 
            /// *   1: adds one or more instances.
            /// *   2: modifies the configurations of an instance. In the upgrade scenario, if the configurations of the pricing module change, you must specify this value for the parameter.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("ModuleStatus")]
            [Validation(Required=false)]
            public int? ModuleStatus { get; set; }

            /// <summary>
            /// The tag of the specified resource. This parameter is required only if you upgrade or modify the configurations of an Alibaba Cloud service. For example, if you want to modify the configurations of a disk, you can use a tag to identify the ID of the disk.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The type of the order. Valid values:
        /// 
        /// *   NewOrder: purchases an instance of an Alibaba Cloud service.
        /// *   Renewal: renews an instance of an Alibaba Cloud service.
        /// *   Upgrade: upgrades an instance of an Alibaba Cloud service.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The code of the service. For more information about the service code, see **Codes of Alibaba Cloud Services**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The type of the service. Specify the parameter based on the pricing document of the specific service.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The quantity.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The service duration.
        /// </summary>
        [NameInMap("ServicePeriodQuantity")]
        [Validation(Required=false)]
        public int? ServicePeriodQuantity { get; set; }

        /// <summary>
        /// The unit of the service duration. Valid values:
        /// 
        /// *   Year
        /// *   Month
        /// </summary>
        [NameInMap("ServicePeriodUnit")]
        [Validation(Required=false)]
        public string ServicePeriodUnit { get; set; }

        /// <summary>
        /// The billing method. Set the value to Subscription.
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}

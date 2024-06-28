// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. The server checks whether a request that uses the same client token has been received. If a request that uses the same client token has been received, the server returns the same request result as the previous request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The logistics address of this order. This parameter is generally valid for physical orders.
        /// </summary>
        [NameInMap("Logistics")]
        [Validation(Required=false)]
        public string Logistics { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The details of the modules.
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestParameter> Parameter { get; set; }
        public class CreateInstanceRequestParameter : TeaModel {
            /// <summary>
            /// The code property of the Nth module. Value of N: 1 to 100. If multiple module property parameters are involved, concatenate multiple parameters based on the value of N in sequence.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The value property of the Nth module. Value of N: 1 to 100.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The subscription duration. Unit: month. The value must be an integral multiple of 12.
        /// 
        /// >  This parameter is required if you create a subscription instance.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The code of the service to which the instance belongs. You can query the service code by calling the **QueryProductList** operation or viewing **Codes of Alibaba Cloud Services**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The type of the service.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The auto-renewal period. Unit: month.
        /// 
        /// >  This parameter is required if the **RenewalStatus** parameter is set to **AutoRenewal**.
        /// </summary>
        [NameInMap("RenewPeriod")]
        [Validation(Required=false)]
        public int? RenewPeriod { get; set; }

        /// <summary>
        /// The renewal method. Valid values:
        /// 
        /// *   AutoRenewal: The instance is automatically renewed.
        /// *   ManualRenewal: The instance is manually renewed.
        /// 
        /// Default value: ManualRenewal.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   Subscription: the subscription billing method.
        /// *   PayAsYouGo: the pay-as-you-go billing method.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}

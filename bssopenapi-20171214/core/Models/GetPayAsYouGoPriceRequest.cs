// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetPayAsYouGoPriceRequest : TeaModel {
        /// <summary>
        /// The details of pricing modules.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ModuleList")]
        [Validation(Required=false)]
        public List<GetPayAsYouGoPriceRequestModuleList> ModuleList { get; set; }
        public class GetPayAsYouGoPriceRequestModuleList : TeaModel {
            /// <summary>
            /// The configuration of the Nth pricing module. Valid values of N: 1 to 50. Format: AA:aa,BB:bb. The values of AA and BB are the property IDs of the pricing module. The values of aa and bb are the property values of the pricing module.
            /// 
            /// >  You can call the [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html) operation to obtain the configuration parameters of the pricing module.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The code of the Nth pricing module.
            /// 
            /// >  You can call the [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html) operation to obtain the module code.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// The price type of the Nth pricing module. Valid values:
            /// 
            /// *   Hour: hourly price
            /// *   Usage: usage price
            /// *   Month: monthly price
            /// *   Year: annual price
            /// 
            /// >  You can call the [DescribePricingModule](https://help.aliyun.com/document_detail/96469.html) operation to obtain the configuration parameters of the pricing module.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("PriceType")]
            [Validation(Required=false)]
            public string PriceType { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The code of the service.
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
        /// The ID of the region in which the instance resides.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The billing method. Set the value to PayAsYouGo.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}

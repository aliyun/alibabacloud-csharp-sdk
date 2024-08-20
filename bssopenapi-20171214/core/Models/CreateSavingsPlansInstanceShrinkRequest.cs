// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateSavingsPlansInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// The code of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The service duration. This parameter is used together with the PricingCycle parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The time when the savings plan takes effect. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// The extended parameters.
        /// </summary>
        [NameInMap("ExtendMap")]
        [Validation(Required=false)]
        public string ExtendMapShrink { get; set; }

        /// <summary>
        /// The payment mode. Valid values:
        /// 
        /// *   total: all upfront
        /// *   half: partial upfront
        /// *   zero: no upfront
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayMode")]
        [Validation(Required=false)]
        public string PayMode { get; set; }

        /// <summary>
        /// The contracted amount. unit: CNY
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PoolValue")]
        [Validation(Required=false)]
        public string PoolValue { get; set; }

        /// <summary>
        /// The unit of the subscription duration. This parameter is used together with Duration. Valid values:
        /// 
        /// *   Year
        /// *   Month
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the region in which you create the savings plan. You must specify this parameter if the Type parameter is not set to universal.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The specification type. This parameter is used together with the Specification parameter. You must specify this parameter if the Type parameter is not set to universal. Valid values:
        /// 
        /// *   group: specification group
        /// *   family: specification family
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// The specifications of the savings plan. This parameter is used together with the SpecType parameter.
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// The type of the savings plan. Valid values:
        /// 
        /// *   universal: general-purpose type
        /// *   ecs: Elastic Compute Service (ECS) compute type
        /// *   elasticy: elastic type
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

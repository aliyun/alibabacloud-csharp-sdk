// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ChangeResellerConsumeAmountRequest : TeaModel {
        /// <summary>
        /// The type of the consumption amount adjustment. Valid values: increase: The consumption amount increases because new consumption occurs. decrease: The consumption amount decreases because funds are added to the account. This parameter is required.
        /// </summary>
        [NameInMap("AdjustType")]
        [Validation(Required=false)]
        public string AdjustType { get; set; }

        /// <summary>
        /// The amount to be adjusted. Unit: CNY
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// The type of the business.
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The type of the currency.
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The extended field of a message.
        /// </summary>
        [NameInMap("ExtendMap")]
        [Validation(Required=false)]
        public string ExtendMap { get; set; }

        /// <summary>
        /// The ID of the primary key for external business. The ID is used for idempotence verification.
        /// </summary>
        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The source of the request. Specify the system name for the parameter.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}

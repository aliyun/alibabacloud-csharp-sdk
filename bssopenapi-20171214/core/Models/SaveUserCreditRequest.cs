// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SaveUserCreditRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable service suspension protection for pay-as-you-go services.
        /// </summary>
        [NameInMap("AvoidExpiration")]
        [Validation(Required=false)]
        public bool? AvoidExpiration { get; set; }

        /// <summary>
        /// Specifies whether to allow the use of pay-as-you-go services without the need to send notifications.
        /// </summary>
        [NameInMap("AvoidNotification")]
        [Validation(Required=false)]
        public bool? AvoidNotification { get; set; }

        /// <summary>
        /// Specifies whether to enable service suspension protection for subscription services.
        /// </summary>
        [NameInMap("AvoidPrepaidExpiration")]
        [Validation(Required=false)]
        public bool? AvoidPrepaidExpiration { get; set; }

        /// <summary>
        /// Specifies whether to allow the use of subscription services without the need to send notifications.
        /// </summary>
        [NameInMap("AvoidPrepaidNotification")]
        [Validation(Required=false)]
        public bool? AvoidPrepaidNotification { get; set; }

        /// <summary>
        /// The type of the credit.
        /// </summary>
        [NameInMap("CreditType")]
        [Validation(Required=false)]
        public string CreditType { get; set; }

        /// <summary>
        /// The value of the credit.
        /// </summary>
        [NameInMap("CreditValue")]
        [Validation(Required=false)]
        public string CreditValue { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The operator who performs the action.
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}

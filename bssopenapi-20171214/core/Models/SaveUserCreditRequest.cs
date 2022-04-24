// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SaveUserCreditRequest : TeaModel {
        [NameInMap("AvoidExpiration")]
        [Validation(Required=false)]
        public bool? AvoidExpiration { get; set; }

        [NameInMap("AvoidNotification")]
        [Validation(Required=false)]
        public bool? AvoidNotification { get; set; }

        [NameInMap("AvoidPrepaidExpiration")]
        [Validation(Required=false)]
        public bool? AvoidPrepaidExpiration { get; set; }

        [NameInMap("AvoidPrepaidNotification")]
        [Validation(Required=false)]
        public bool? AvoidPrepaidNotification { get; set; }

        [NameInMap("CreditType")]
        [Validation(Required=false)]
        public string CreditType { get; set; }

        [NameInMap("CreditValue")]
        [Validation(Required=false)]
        public string CreditValue { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class SetPurchasedApiGroupStatusRequest : TeaModel {
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("BillingStatus")]
        [Validation(Required=false)]
        public string BillingStatus { get; set; }

        [NameInMap("CloseOrder")]
        [Validation(Required=false)]
        public bool? CloseOrder { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}

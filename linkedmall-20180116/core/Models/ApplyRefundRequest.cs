// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ApplyRefundRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("ApplyReasonTextId")]
        [Validation(Required=false)]
        public long? ApplyReasonTextId { get; set; }

        [NameInMap("ApplyRefundCount")]
        [Validation(Required=false)]
        public int? ApplyRefundCount { get; set; }

        [NameInMap("ApplyRefundFee")]
        [Validation(Required=false)]
        public long? ApplyRefundFee { get; set; }

        [NameInMap("BizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizUid")]
        [Validation(Required=false)]
        public string BizUid { get; set; }

        [NameInMap("GoodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        [NameInMap("LeaveMessage")]
        [Validation(Required=false)]
        public string LeaveMessage { get; set; }

        [NameInMap("LeavePictureList")]
        [Validation(Required=false)]
        public List<ApplyRefundRequestLeavePictureList> LeavePictureList { get; set; }
        public class ApplyRefundRequestLeavePictureList : TeaModel {
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Picture")]
            [Validation(Required=false)]
            public string Picture { get; set; }

        }

        [NameInMap("SubLmOrderId")]
        [Validation(Required=false)]
        public string SubLmOrderId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

        [NameInMap("UseAnonymousTbAccount")]
        [Validation(Required=false)]
        public bool? UseAnonymousTbAccount { get; set; }

    }

}

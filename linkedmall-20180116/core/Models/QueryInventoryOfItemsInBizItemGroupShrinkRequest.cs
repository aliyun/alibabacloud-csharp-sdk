// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryInventoryOfItemsInBizItemGroupShrinkRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DivisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public string ItemIdsShrink { get; set; }

        [NameInMap("LmItemIds")]
        [Validation(Required=false)]
        public string LmItemIdsShrink { get; set; }

        [NameInMap("SubBizId")]
        [Validation(Required=false)]
        public string SubBizId { get; set; }

    }

}

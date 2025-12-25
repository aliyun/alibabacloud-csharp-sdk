// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class PromotionInfo : TeaModel {
        [NameInMap("canPromFee")]
        [Validation(Required=false)]
        public string CanPromFee { get; set; }

        [NameInMap("isSelected")]
        [Validation(Required=false)]
        public bool? IsSelected { get; set; }

        [NameInMap("promotionDesc")]
        [Validation(Required=false)]
        public string PromotionDesc { get; set; }

        [NameInMap("promotionName")]
        [Validation(Required=false)]
        public string PromotionName { get; set; }

        [NameInMap("promotionOptionCode")]
        [Validation(Required=false)]
        public string PromotionOptionCode { get; set; }

        [NameInMap("promotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        [NameInMap("selected")]
        [Validation(Required=false)]
        public bool? Selected { get; set; }

    }

}

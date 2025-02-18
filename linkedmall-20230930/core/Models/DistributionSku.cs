// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DistributionSku : TeaModel {
        [NameInMap("aliasTitle")]
        [Validation(Required=false)]
        public string AliasTitle { get; set; }

        [NameInMap("barCode")]
        [Validation(Required=false)]
        public string BarCode { get; set; }

        [NameInMap("creditPeriod")]
        [Validation(Required=false)]
        public int? CreditPeriod { get; set; }

        [NameInMap("dxPrice")]
        [Validation(Required=false)]
        public long? DxPrice { get; set; }

        [NameInMap("hasCredit")]
        [Validation(Required=false)]
        public bool? HasCredit { get; set; }

        [NameInMap("hasInvoice")]
        [Validation(Required=false)]
        public bool? HasInvoice { get; set; }

        [NameInMap("jxPrice")]
        [Validation(Required=false)]
        public long? JxPrice { get; set; }

        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("skuStatus")]
        [Validation(Required=false)]
        public string SkuStatus { get; set; }

        [NameInMap("taxCode")]
        [Validation(Required=false)]
        public string TaxCode { get; set; }

        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public int? TaxRate { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

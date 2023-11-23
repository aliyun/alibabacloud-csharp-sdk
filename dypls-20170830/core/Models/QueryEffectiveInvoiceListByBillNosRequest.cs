// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypls20170830.Models
{
    public class QueryEffectiveInvoiceListByBillNosRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("BillNo")]
        [Validation(Required=false)]
        public string BillNo { get; set; }

        [NameInMap("EncryptProps")]
        [Validation(Required=false)]
        public Dictionary<string, string> EncryptProps { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MajorBillNo")]
        [Validation(Required=false)]
        public string MajorBillNo { get; set; }

        [NameInMap("OuCode")]
        [Validation(Required=false)]
        public string OuCode { get; set; }

        [NameInMap("RelatedSystem")]
        [Validation(Required=false)]
        public string RelatedSystem { get; set; }

        [NameInMap("Sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}

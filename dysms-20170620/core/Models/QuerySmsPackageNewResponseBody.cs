// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsPackageNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySmsPackageNewResponseBodyList List { get; set; }
        public class QuerySmsPackageNewResponseBodyList : TeaModel {
            [NameInMap("SmsPackageInfo")]
            [Validation(Required=false)]
            public List<QuerySmsPackageNewResponseBodyListSmsPackageInfo> SmsPackageInfo { get; set; }
            public class QuerySmsPackageNewResponseBodyListSmsPackageInfo : TeaModel {
                [NameInMap("BuyTime")]
                [Validation(Required=false)]
                public string BuyTime { get; set; }

                [NameInMap("DetailOrderId")]
                [Validation(Required=false)]
                public string DetailOrderId { get; set; }

                [NameInMap("EffTime")]
                [Validation(Required=false)]
                public string EffTime { get; set; }

                [NameInMap("ExpTime")]
                [Validation(Required=false)]
                public string ExpTime { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("PackageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("PayPrice")]
                [Validation(Required=false)]
                public float? PayPrice { get; set; }

                [NameInMap("PkgId")]
                [Validation(Required=false)]
                public long? PkgId { get; set; }

                [NameInMap("RefundStatus")]
                [Validation(Required=false)]
                public int? RefundStatus { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Usage")]
                [Validation(Required=false)]
                public long? Usage { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

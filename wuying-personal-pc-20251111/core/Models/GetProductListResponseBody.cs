// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class GetProductListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DisplayInfo")]
        [Validation(Required=false)]
        public GetProductListResponseBodyDisplayInfo DisplayInfo { get; set; }
        public class GetProductListResponseBodyDisplayInfo : TeaModel {
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<GetProductListResponseBodyDisplayInfoProductList> ProductList { get; set; }
            public class GetProductListResponseBodyDisplayInfoProductList : TeaModel {
                [NameInMap("DisplayAttribute")]
                [Validation(Required=false)]
                public string DisplayAttribute { get; set; }

                [NameInMap("DisplayConfig")]
                [Validation(Required=false)]
                public string DisplayConfig { get; set; }

                [NameInMap("DynamicAttribute")]
                [Validation(Required=false)]
                public string DynamicAttribute { get; set; }

                [NameInMap("IsEnable")]
                [Validation(Required=false)]
                public bool? IsEnable { get; set; }

                [NameInMap("ModificationLevel")]
                [Validation(Required=false)]
                public int? ModificationLevel { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductDesc")]
                [Validation(Required=false)]
                public string ProductDesc { get; set; }

                [NameInMap("ProductGroup")]
                [Validation(Required=false)]
                public string ProductGroup { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("SkuList")]
                [Validation(Required=false)]
                public List<GetProductListResponseBodyDisplayInfoProductListSkuList> SkuList { get; set; }
                public class GetProductListResponseBodyDisplayInfoProductListSkuList : TeaModel {
                    [NameInMap("AppleSkuCode")]
                    [Validation(Required=false)]
                    public string AppleSkuCode { get; set; }

                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public string Attribute { get; set; }

                    [NameInMap("PurchaseMode")]
                    [Validation(Required=false)]
                    public string PurchaseMode { get; set; }

                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public string SkuCode { get; set; }

                    [NameInMap("SkuDesc")]
                    [Validation(Required=false)]
                    public string SkuDesc { get; set; }

                    [NameInMap("SkuName")]
                    [Validation(Required=false)]
                    public string SkuName { get; set; }

                }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

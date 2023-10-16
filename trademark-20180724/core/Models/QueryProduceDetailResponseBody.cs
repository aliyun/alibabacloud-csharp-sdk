// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryProduceDetailResponseBody : TeaModel {
        [NameInMap("AcceptUrl")]
        [Validation(Required=false)]
        public string AcceptUrl { get; set; }

        [NameInMap("AgreementId")]
        [Validation(Required=false)]
        public string AgreementId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("CnInfoUrl")]
        [Validation(Required=false)]
        public string CnInfoUrl { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendInfo { get; set; }

        [NameInMap("Flags")]
        [Validation(Required=false)]
        public QueryProduceDetailResponseBodyFlags Flags { get; set; }
        public class QueryProduceDetailResponseBodyFlags : TeaModel {
            [NameInMap("Flags")]
            [Validation(Required=false)]
            public List<string> Flags { get; set; }

        }

        [NameInMap("GrayIconUrl")]
        [Validation(Required=false)]
        public string GrayIconUrl { get; set; }

        [NameInMap("IssueDate")]
        [Validation(Required=false)]
        public string IssueDate { get; set; }

        [NameInMap("LeafCodes")]
        [Validation(Required=false)]
        public QueryProduceDetailResponseBodyLeafCodes LeafCodes { get; set; }
        public class QueryProduceDetailResponseBodyLeafCodes : TeaModel {
            [NameInMap("LeafCodes")]
            [Validation(Required=false)]
            public List<QueryProduceDetailResponseBodyLeafCodesLeafCodes> LeafCodes { get; set; }
            public class QueryProduceDetailResponseBodyLeafCodesLeafCodes : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("LoaUrl")]
        [Validation(Required=false)]
        public string LoaUrl { get; set; }

        [NameInMap("MaterialDetail")]
        [Validation(Required=false)]
        public QueryProduceDetailResponseBodyMaterialDetail MaterialDetail { get; set; }
        public class QueryProduceDetailResponseBodyMaterialDetail : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("BusinessLicenceUrl")]
            [Validation(Required=false)]
            public string BusinessLicenceUrl { get; set; }

            [NameInMap("CardNumber")]
            [Validation(Required=false)]
            public string CardNumber { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("ContactAddress")]
            [Validation(Required=false)]
            public string ContactAddress { get; set; }

            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("ContactNumber")]
            [Validation(Required=false)]
            public string ContactNumber { get; set; }

            [NameInMap("ContactZipcode")]
            [Validation(Required=false)]
            public string ContactZipcode { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("EAddress")]
            [Validation(Required=false)]
            public string EAddress { get; set; }

            [NameInMap("EName")]
            [Validation(Required=false)]
            public string EName { get; set; }

            [NameInMap("ExpirationDate")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            [NameInMap("IdCardUrl")]
            [Validation(Required=false)]
            public string IdCardUrl { get; set; }

            [NameInMap("LoaUrl")]
            [Validation(Required=false)]
            public string LoaUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PassportUrl")]
            [Validation(Required=false)]
            public string PassportUrl { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Town")]
            [Validation(Required=false)]
            public string Town { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RootCode")]
        [Validation(Required=false)]
        public QueryProduceDetailResponseBodyRootCode RootCode { get; set; }
        public class QueryProduceDetailResponseBodyRootCode : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SubmitCount")]
        [Validation(Required=false)]
        public int? SubmitCount { get; set; }

        [NameInMap("TmIcon")]
        [Validation(Required=false)]
        public string TmIcon { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmNameType")]
        [Validation(Required=false)]
        public int? TmNameType { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("TmOrderId")]
        [Validation(Required=false)]
        public string TmOrderId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}

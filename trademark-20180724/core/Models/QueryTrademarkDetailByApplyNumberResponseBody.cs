// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkDetailByApplyNumberResponseBody : TeaModel {
        [NameInMap("Moudle")]
        [Validation(Required=false)]
        public QueryTrademarkDetailByApplyNumberResponseBodyMoudle Moudle { get; set; }
        public class QueryTrademarkDetailByApplyNumberResponseBodyMoudle : TeaModel {
            [NameInMap("BitFlag")]
            [Validation(Required=false)]
            public int? BitFlag { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("GrayIconUrl")]
            [Validation(Required=false)]
            public string GrayIconUrl { get; set; }

            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("LeafCodes")]
            [Validation(Required=false)]
            public QueryTrademarkDetailByApplyNumberResponseBodyMoudleLeafCodes LeafCodes { get; set; }
            public class QueryTrademarkDetailByApplyNumberResponseBodyMoudleLeafCodes : TeaModel {
                [NameInMap("leafCode")]
                [Validation(Required=false)]
                public List<QueryTrademarkDetailByApplyNumberResponseBodyMoudleLeafCodesLeafCode> LeafCode { get; set; }
                public class QueryTrademarkDetailByApplyNumberResponseBodyMoudleLeafCodesLeafCode : TeaModel {
                    [NameInMap("ClassificationCode")]
                    [Validation(Required=false)]
                    public string ClassificationCode { get; set; }

                    [NameInMap("ClassificationName")]
                    [Validation(Required=false)]
                    public string ClassificationName { get; set; }

                }

            }

            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public QueryTrademarkDetailByApplyNumberResponseBodyMoudleMaterialInfo MaterialInfo { get; set; }
            public class QueryTrademarkDetailByApplyNumberResponseBodyMoudleMaterialInfo : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("BusinessLicenceUrl")]
                [Validation(Required=false)]
                public string BusinessLicenceUrl { get; set; }

                [NameInMap("CardNumber")]
                [Validation(Required=false)]
                public string CardNumber { get; set; }

                [NameInMap("CnInfoUrl")]
                [Validation(Required=false)]
                public string CnInfoUrl { get; set; }

                [NameInMap("ContactAddress")]
                [Validation(Required=false)]
                public string ContactAddress { get; set; }

                [NameInMap("ContactEmail")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("ContactPhoneNumber")]
                [Validation(Required=false)]
                public string ContactPhoneNumber { get; set; }

                [NameInMap("ContactZipCode")]
                [Validation(Required=false)]
                public string ContactZipCode { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("EAddress")]
                [Validation(Required=false)]
                public string EAddress { get; set; }

                [NameInMap("EName")]
                [Validation(Required=false)]
                public string EName { get; set; }

                [NameInMap("IdCardNumber")]
                [Validation(Required=false)]
                public string IdCardNumber { get; set; }

                [NameInMap("IdCardUrl")]
                [Validation(Required=false)]
                public string IdCardUrl { get; set; }

                [NameInMap("LoaKey")]
                [Validation(Required=false)]
                public string LoaKey { get; set; }

                [NameInMap("LoaUrl")]
                [Validation(Required=false)]
                public string LoaUrl { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PassportUrl")]
                [Validation(Required=false)]
                public string PassportUrl { get; set; }

                [NameInMap("PersonalType")]
                [Validation(Required=false)]
                public int? PersonalType { get; set; }

                [NameInMap("PostCode")]
                [Validation(Required=false)]
                public string PostCode { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("ReasonFileOssKey")]
                [Validation(Required=false)]
                public string ReasonFileOssKey { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                [NameInMap("ReviewFileMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> ReviewFileMap { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PartnerCode")]
            [Validation(Required=false)]
            public string PartnerCode { get; set; }

            [NameInMap("PrincipalKey")]
            [Validation(Required=false)]
            public string PrincipalKey { get; set; }

            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            [NameInMap("ProduceType")]
            [Validation(Required=false)]
            public string ProduceType { get; set; }

            [NameInMap("RootCode")]
            [Validation(Required=false)]
            public QueryTrademarkDetailByApplyNumberResponseBodyMoudleRootCode RootCode { get; set; }
            public class QueryTrademarkDetailByApplyNumberResponseBodyMoudleRootCode : TeaModel {
                [NameInMap("ClassificationCode")]
                [Validation(Required=false)]
                public string ClassificationCode { get; set; }

                [NameInMap("ClassificationName")]
                [Validation(Required=false)]
                public string ClassificationName { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusStr")]
            [Validation(Required=false)]
            public string StatusStr { get; set; }

            [NameInMap("SubmitAuditTimeStr")]
            [Validation(Required=false)]
            public string SubmitAuditTimeStr { get; set; }

            [NameInMap("SubmitAuditTimeValue")]
            [Validation(Required=false)]
            public long? SubmitAuditTimeValue { get; set; }

            [NameInMap("SubmitStatus")]
            [Validation(Required=false)]
            public string SubmitStatus { get; set; }

            [NameInMap("SubmitTimeStr")]
            [Validation(Required=false)]
            public string SubmitTimeStr { get; set; }

            [NameInMap("SubmitTimeValue")]
            [Validation(Required=false)]
            public long? SubmitTimeValue { get; set; }

            [NameInMap("SubmitTimes")]
            [Validation(Required=false)]
            public int? SubmitTimes { get; set; }

            [NameInMap("TrademarkName")]
            [Validation(Required=false)]
            public string TrademarkName { get; set; }

            [NameInMap("TrademarkNameType")]
            [Validation(Required=false)]
            public int? TrademarkNameType { get; set; }

            [NameInMap("TrademarkNumber")]
            [Validation(Required=false)]
            public string TrademarkNumber { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

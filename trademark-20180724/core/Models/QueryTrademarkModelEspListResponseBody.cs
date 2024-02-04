// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkModelEspListResponseBody : TeaModel {
        [NameInMap("Moudle")]
        [Validation(Required=false)]
        public QueryTrademarkModelEspListResponseBodyMoudle Moudle { get; set; }
        public class QueryTrademarkModelEspListResponseBodyMoudle : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryTrademarkModelEspListResponseBodyMoudleData Data { get; set; }
            public class QueryTrademarkModelEspListResponseBodyMoudleData : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<QueryTrademarkModelEspListResponseBodyMoudleDataItem> Item { get; set; }
                public class QueryTrademarkModelEspListResponseBodyMoudleDataItem : TeaModel {
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
                    public QueryTrademarkModelEspListResponseBodyMoudleDataItemLeafCodes LeafCodes { get; set; }
                    public class QueryTrademarkModelEspListResponseBodyMoudleDataItemLeafCodes : TeaModel {
                        [NameInMap("leafCode")]
                        [Validation(Required=false)]
                        public List<QueryTrademarkModelEspListResponseBodyMoudleDataItemLeafCodesLeafCode> LeafCode { get; set; }
                        public class QueryTrademarkModelEspListResponseBodyMoudleDataItemLeafCodesLeafCode : TeaModel {
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
                    public QueryTrademarkModelEspListResponseBodyMoudleDataItemMaterialInfo MaterialInfo { get; set; }
                    public class QueryTrademarkModelEspListResponseBodyMoudleDataItemMaterialInfo : TeaModel {
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
                        public string PersonalType { get; set; }

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
                    public QueryTrademarkModelEspListResponseBodyMoudleDataItemRootCode RootCode { get; set; }
                    public class QueryTrademarkModelEspListResponseBodyMoudleDataItemRootCode : TeaModel {
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

                    [NameInMap("SubmitAuditTime")]
                    [Validation(Required=false)]
                    public long? SubmitAuditTime { get; set; }

                    [NameInMap("SubmitStatus")]
                    [Validation(Required=false)]
                    public string SubmitStatus { get; set; }

                    [NameInMap("SubmitTime")]
                    [Validation(Required=false)]
                    public long? SubmitTime { get; set; }

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

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("TotalPageNum")]
            [Validation(Required=false)]
            public int? TotalPageNum { get; set; }

        }

    }

}

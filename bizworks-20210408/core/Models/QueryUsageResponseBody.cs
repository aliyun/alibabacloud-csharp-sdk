/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BizWorks20210408.Models
{
    public class QueryUsageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryUsageResponseBodyData Data { get; set; }
        public class QueryUsageResponseBodyData : TeaModel {
            [NameInMap("articleInfos")]
            [Validation(Required=false)]
            public List<QueryUsageResponseBodyDataArticleInfos> ArticleInfos { get; set; }
            public class QueryUsageResponseBodyDataArticleInfos : TeaModel {
                [NameInMap("articleType")]
                [Validation(Required=false)]
                public string ArticleType { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("commoditySpecUsageInfos")]
            [Validation(Required=false)]
            public List<QueryUsageResponseBodyDataCommoditySpecUsageInfos> CommoditySpecUsageInfos { get; set; }
            public class QueryUsageResponseBodyDataCommoditySpecUsageInfos : TeaModel {
                [NameInMap("commodityConfig")]
                [Validation(Required=false)]
                public QueryUsageResponseBodyDataCommoditySpecUsageInfosCommodityConfig CommodityConfig { get; set; }
                public class QueryUsageResponseBodyDataCommoditySpecUsageInfosCommodityConfig : TeaModel {
                    [NameInMap("betaDeadlineMs")]
                    [Validation(Required=false)]
                    public long? BetaDeadlineMs { get; set; }

                    [NameInMap("commodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    [NameInMap("commodityName")]
                    [Validation(Required=false)]
                    public string CommodityName { get; set; }

                    [NameInMap("expiredToReleasedHour")]
                    [Validation(Required=false)]
                    public long? ExpiredToReleasedHour { get; set; }

                    [NameInMap("inBeta")]
                    [Validation(Required=false)]
                    public bool? InBeta { get; set; }

                    [NameInMap("independent")]
                    [Validation(Required=false)]
                    public bool? Independent { get; set; }

                    [NameInMap("paidType")]
                    [Validation(Required=false)]
                    public string PaidType { get; set; }

                    [NameInMap("productCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    [NameInMap("quotaItems")]
                    [Validation(Required=false)]
                    public List<string> QuotaItems { get; set; }

                    [NameInMap("specCodes")]
                    [Validation(Required=false)]
                    public List<string> SpecCodes { get; set; }

                }

                [NameInMap("purchasedCommoditySpecUsages")]
                [Validation(Required=false)]
                public List<QueryUsageResponseBodyDataCommoditySpecUsageInfosPurchasedCommoditySpecUsages> PurchasedCommoditySpecUsages { get; set; }
                public class QueryUsageResponseBodyDataCommoditySpecUsageInfosPurchasedCommoditySpecUsages : TeaModel {
                    [NameInMap("commoditySpec")]
                    [Validation(Required=false)]
                    public QueryUsageResponseBodyDataCommoditySpecUsageInfosPurchasedCommoditySpecUsagesCommoditySpec CommoditySpec { get; set; }
                    public class QueryUsageResponseBodyDataCommoditySpecUsageInfosPurchasedCommoditySpecUsagesCommoditySpec : TeaModel {
                        [NameInMap("applicationNum")]
                        [Validation(Required=false)]
                        public string ApplicationNum { get; set; }

                        [NameInMap("commercializeStatus")]
                        [Validation(Required=false)]
                        public string CommercializeStatus { get; set; }

                        [NameInMap("commodityCode")]
                        [Validation(Required=false)]
                        public string CommodityCode { get; set; }

                        [NameInMap("commodityName")]
                        [Validation(Required=false)]
                        public string CommodityName { get; set; }

                        [NameInMap("cpuNum")]
                        [Validation(Required=false)]
                        public long? CpuNum { get; set; }

                        [NameInMap("expireDate")]
                        [Validation(Required=false)]
                        public long? ExpireDate { get; set; }

                        [NameInMap("memNum")]
                        [Validation(Required=false)]
                        public long? MemNum { get; set; }

                        [NameInMap("nextBuyActions")]
                        [Validation(Required=false)]
                        public List<string> NextBuyActions { get; set; }

                        [NameInMap("ntmCommodityInstanceId")]
                        [Validation(Required=false)]
                        public string NtmCommodityInstanceId { get; set; }

                        [NameInMap("openDate")]
                        [Validation(Required=false)]
                        public long? OpenDate { get; set; }

                        [NameInMap("relatedSubProducts")]
                        [Validation(Required=false)]
                        public List<string> RelatedSubProducts { get; set; }

                        [NameInMap("remainingTime")]
                        [Validation(Required=false)]
                        public string RemainingTime { get; set; }

                        [NameInMap("specCode")]
                        [Validation(Required=false)]
                        public string SpecCode { get; set; }

                    }

                    [NameInMap("commodityUsage")]
                    [Validation(Required=false)]
                    public QueryUsageResponseBodyDataCommoditySpecUsageInfosPurchasedCommoditySpecUsagesCommodityUsage CommodityUsage { get; set; }
                    public class QueryUsageResponseBodyDataCommoditySpecUsageInfosPurchasedCommoditySpecUsagesCommodityUsage : TeaModel {
                        [NameInMap("applicationNum")]
                        [Validation(Required=false)]
                        public long? ApplicationNum { get; set; }

                        [NameInMap("cpuNum")]
                        [Validation(Required=false)]
                        public long? CpuNum { get; set; }

                        [NameInMap("memNum")]
                        [Validation(Required=false)]
                        public long? MemNum { get; set; }

                    }

                }

            }

            [NameInMap("subProductInfos")]
            [Validation(Required=false)]
            public List<QueryUsageResponseBodyDataSubProductInfos> SubProductInfos { get; set; }
            public class QueryUsageResponseBodyDataSubProductInfos : TeaModel {
                [NameInMap("subProduct")]
                [Validation(Required=false)]
                public QueryUsageResponseBodyDataSubProductInfosSubProduct SubProduct { get; set; }
                public class QueryUsageResponseBodyDataSubProductInfosSubProduct : TeaModel {
                    [NameInMap("display")]
                    [Validation(Required=false)]
                    public bool? Display { get; set; }

                    [NameInMap("extendProperties")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtendProperties { get; set; }

                    [NameInMap("subProductCode")]
                    [Validation(Required=false)]
                    public string SubProductCode { get; set; }

                    [NameInMap("subProductName")]
                    [Validation(Required=false)]
                    public string SubProductName { get; set; }

                    [NameInMap("subProductState")]
                    [Validation(Required=false)]
                    public string SubProductState { get; set; }

                }

                [NameInMap("subProductCommoditySpecsForGuideToBuy")]
                [Validation(Required=false)]
                public List<QueryUsageResponseBodyDataSubProductInfosSubProductCommoditySpecsForGuideToBuy> SubProductCommoditySpecsForGuideToBuy { get; set; }
                public class QueryUsageResponseBodyDataSubProductInfosSubProductCommoditySpecsForGuideToBuy : TeaModel {
                    [NameInMap("commodityConfig")]
                    [Validation(Required=false)]
                    public QueryUsageResponseBodyDataSubProductInfosSubProductCommoditySpecsForGuideToBuyCommodityConfig CommodityConfig { get; set; }
                    public class QueryUsageResponseBodyDataSubProductInfosSubProductCommoditySpecsForGuideToBuyCommodityConfig : TeaModel {
                        [NameInMap("betaDeadlineMs")]
                        [Validation(Required=false)]
                        public long? BetaDeadlineMs { get; set; }

                        [NameInMap("commodityCode")]
                        [Validation(Required=false)]
                        public string CommodityCode { get; set; }

                        [NameInMap("commodityName")]
                        [Validation(Required=false)]
                        public string CommodityName { get; set; }

                        [NameInMap("expiredToReleasedHour")]
                        [Validation(Required=false)]
                        public long? ExpiredToReleasedHour { get; set; }

                        [NameInMap("inBeta")]
                        [Validation(Required=false)]
                        public bool? InBeta { get; set; }

                        [NameInMap("independent")]
                        [Validation(Required=false)]
                        public bool? Independent { get; set; }

                        [NameInMap("paidType")]
                        [Validation(Required=false)]
                        public string PaidType { get; set; }

                        [NameInMap("productCode")]
                        [Validation(Required=false)]
                        public string ProductCode { get; set; }

                        [NameInMap("quotaItems")]
                        [Validation(Required=false)]
                        public List<string> QuotaItems { get; set; }

                        [NameInMap("specCodes")]
                        [Validation(Required=false)]
                        public List<string> SpecCodes { get; set; }

                    }

                    [NameInMap("commoditySpec")]
                    [Validation(Required=false)]
                    public QueryUsageResponseBodyDataSubProductInfosSubProductCommoditySpecsForGuideToBuyCommoditySpec CommoditySpec { get; set; }
                    public class QueryUsageResponseBodyDataSubProductInfosSubProductCommoditySpecsForGuideToBuyCommoditySpec : TeaModel {
                        [NameInMap("applicationNum")]
                        [Validation(Required=false)]
                        public long? ApplicationNum { get; set; }

                        [NameInMap("commercializeStatus")]
                        [Validation(Required=false)]
                        public string CommercializeStatus { get; set; }

                        [NameInMap("commodityCode")]
                        [Validation(Required=false)]
                        public string CommodityCode { get; set; }

                        [NameInMap("commodityName")]
                        [Validation(Required=false)]
                        public string CommodityName { get; set; }

                        [NameInMap("cpuNum")]
                        [Validation(Required=false)]
                        public long? CpuNum { get; set; }

                        [NameInMap("expireDate")]
                        [Validation(Required=false)]
                        public long? ExpireDate { get; set; }

                        [NameInMap("memNum")]
                        [Validation(Required=false)]
                        public long? MemNum { get; set; }

                        [NameInMap("nextBuyActions")]
                        [Validation(Required=false)]
                        public string NextBuyActions { get; set; }

                        [NameInMap("ntmCommodityInstanceId")]
                        [Validation(Required=false)]
                        public string NtmCommodityInstanceId { get; set; }

                        [NameInMap("openDate")]
                        [Validation(Required=false)]
                        public long? OpenDate { get; set; }

                        [NameInMap("relatedSubProducts")]
                        [Validation(Required=false)]
                        public List<string> RelatedSubProducts { get; set; }

                        [NameInMap("specCode")]
                        [Validation(Required=false)]
                        public string SpecCode { get; set; }

                        [NameInMap("specName")]
                        [Validation(Required=false)]
                        public string SpecName { get; set; }

                    }

                    [NameInMap("releaseTime")]
                    [Validation(Required=false)]
                    public long? ReleaseTime { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

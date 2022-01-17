// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class QueryMarketImagesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryMarketImagesResponseBodyResult Result { get; set; }
        public class QueryMarketImagesResponseBodyResult : TeaModel {
            [NameInMap("ImageProduct")]
            [Validation(Required=false)]
            public List<QueryMarketImagesResponseBodyResultImageProduct> ImageProduct { get; set; }
            public class QueryMarketImagesResponseBodyResultImageProduct : TeaModel {
                public string AgreementUrl { get; set; }
                public string BaseSystem { get; set; }
                public string BuyUrl { get; set; }
                public string CategoryName { get; set; }
                public long? CreatedOn { get; set; }
                public string DetailUrl { get; set; }
                public string ImageProductCode { get; set; }
                public QueryMarketImagesResponseBodyResultImageProductImages Images { get; set; }
                public class QueryMarketImagesResponseBodyResultImageProductImages : TeaModel {
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public List<QueryMarketImagesResponseBodyResultImageProductImagesImage> Image { get; set; }
                    public class QueryMarketImagesResponseBodyResultImageProductImagesImage : TeaModel {
                        [NameInMap("DiskDeviceMappings")]
                        [Validation(Required=false)]
                        public QueryMarketImagesResponseBodyResultImageProductImagesImageDiskDeviceMappings DiskDeviceMappings { get; set; }
                        public class QueryMarketImagesResponseBodyResultImageProductImagesImageDiskDeviceMappings : TeaModel {
                            [NameInMap("DiskDeviceMapping")]
                            [Validation(Required=false)]
                            public List<QueryMarketImagesResponseBodyResultImageProductImagesImageDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                            public class QueryMarketImagesResponseBodyResultImageProductImagesImageDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                                public string Device { get; set; }
                                public string DiskType { get; set; }
                                public string Format { get; set; }
                                public string ImportOSSBucket { get; set; }
                                public string ImportOSSObject { get; set; }
                                public int? Size { get; set; }
                                public string SnapshotId { get; set; }
                            }
                        };

                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                        [NameInMap("ImageSize")]
                        [Validation(Required=false)]
                        public int? ImageSize { get; set; }

                        [NameInMap("IsDefault")]
                        [Validation(Required=false)]
                        public bool? IsDefault { get; set; }

                        [NameInMap("Region")]
                        [Validation(Required=false)]
                        public string Region { get; set; }

                        [NameInMap("SupportIO")]
                        [Validation(Required=false)]
                        public bool? SupportIO { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                        [NameInMap("VersionDescription")]
                        [Validation(Required=false)]
                        public string VersionDescription { get; set; }

                    }

                }
                public int? OsBit { get; set; }
                public string OsKind { get; set; }
                public string PictureUrl { get; set; }
                public QueryMarketImagesResponseBodyResultImageProductPriceInfo PriceInfo { get; set; }
                public class QueryMarketImagesResponseBodyResultImageProductPriceInfo : TeaModel {
                    [NameInMap("Order")]
                    [Validation(Required=false)]
                    public QueryMarketImagesResponseBodyResultImageProductPriceInfoOrder Order { get; set; }
                    public class QueryMarketImagesResponseBodyResultImageProductPriceInfoOrder : TeaModel {
                        [NameInMap("Currency")]
                        [Validation(Required=false)]
                        public string Currency { get; set; }
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }
                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }
                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public int? Period { get; set; }
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }
                        [NameInMap("RuleIdSet")]
                        [Validation(Required=false)]
                        public QueryMarketImagesResponseBodyResultImageProductPriceInfoOrderRuleIdSet RuleIdSet { get; set; }
                        public class QueryMarketImagesResponseBodyResultImageProductPriceInfoOrderRuleIdSet : TeaModel {
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public List<string> RuleId { get; set; }

                        }
                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }
                    };

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public QueryMarketImagesResponseBodyResultImageProductPriceInfoRules Rules { get; set; }
                    public class QueryMarketImagesResponseBodyResultImageProductPriceInfoRules : TeaModel {
                        [NameInMap("Rule")]
                        [Validation(Required=false)]
                        public List<QueryMarketImagesResponseBodyResultImageProductPriceInfoRulesRule> Rule { get; set; }
                        public class QueryMarketImagesResponseBodyResultImageProductPriceInfoRulesRule : TeaModel {
                            public string Name { get; set; }
                            public long? RuleId { get; set; }
                            public string Title { get; set; }
                        }
                    };

                }
                public string ProductName { get; set; }
                public QueryMarketImagesResponseBodyResultImageProductQuota Quota { get; set; }
                public class QueryMarketImagesResponseBodyResultImageProductQuota : TeaModel {
                    [NameInMap("TotalQuota")]
                    [Validation(Required=false)]
                    public long? TotalQuota { get; set; }

                    [NameInMap("UnusedQuota")]
                    [Validation(Required=false)]
                    public long? UnusedQuota { get; set; }

                    [NameInMap("UsingQuota")]
                    [Validation(Required=false)]
                    public long? UsingQuota { get; set; }

                }
                public float? Score { get; set; }
                public string ShortDescription { get; set; }
                public QueryMarketImagesResponseBodyResultImageProductSkuCodes SkuCodes { get; set; }
                public class QueryMarketImagesResponseBodyResultImageProductSkuCodes : TeaModel {
                    [NameInMap("SkuCode")]
                    [Validation(Required=false)]
                    public List<string> SkuCode { get; set; }

                }
                public string SmallPicUrl { get; set; }
                public string StoreUrl { get; set; }
                public string SupplierName { get; set; }
                public bool? SupportIO { get; set; }
                public long? UserCount { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupPriceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeContainerGroupPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeContainerGroupPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("SpotPrices")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoSpotPrices SpotPrices { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoSpotPrices : TeaModel {
                [NameInMap("SpotPrice")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupPriceResponseBodyPriceInfoSpotPricesSpotPrice> SpotPrice { get; set; }
                public class DescribeContainerGroupPriceResponseBodyPriceInfoSpotPricesSpotPrice : TeaModel {
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                    [NameInMap("SpotPrice")]
                    [Validation(Required=false)]
                    public float? SpotPrice { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("OriginPrice")]
                    [Validation(Required=false)]
                    public float? OriginPrice { get; set; }

                }

            }
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("DetailInfo")]
                    [Validation(Required=false)]
                    public List<DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo> DetailInfo { get; set; }
                    public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfo : TeaModel {
                        public string Resource { get; set; }
                        public float? DiscountPrice { get; set; }
                        public float? TradePrice { get; set; }
                        public float? OriginalPrice { get; set; }
                        public DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRules Rules { get; set; }
                        public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRulesRule> Rule { get; set; }
                            public class DescribeContainerGroupPriceResponseBodyPriceInfoPriceDetailInfosDetailInfoRulesRule : TeaModel {
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public long? RuleId { get; set; }

                            }

                        }
                    }
                };

                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

            }
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeContainerGroupPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeContainerGroupPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeContainerGroupPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeContainerGroupPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }
        };

    }

}

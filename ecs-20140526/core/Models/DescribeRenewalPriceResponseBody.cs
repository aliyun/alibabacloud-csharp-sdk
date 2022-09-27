// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRenewalPriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeRenewalPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeRenewalPriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoPrice : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfos DetailInfos { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfos : TeaModel {
                    [NameInMap("ResourcePriceModel")]
                    [Validation(Required=false)]
                    public List<DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModel> ResourcePriceModel { get; set; }
                    public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModel : TeaModel {
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        [NameInMap("SubRules")]
                        [Validation(Required=false)]
                        public DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRules SubRules { get; set; }
                        public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRulesRule> Rule { get; set; }
                            public class DescribeRenewalPriceResponseBodyPriceInfoPriceDetailInfosResourcePriceModelSubRulesRule : TeaModel {
                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public long? RuleId { get; set; }

                            }

                        }

                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribeRenewalPriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribeRenewalPriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribeRenewalPriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribeRenewalPriceResponseBodyPriceInfoRulesRule : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanPriceResponseBody : TeaModel {
        [NameInMap("PriceModel")]
        [Validation(Required=false)]
        public DescribeRatePlanPriceResponseBodyPriceModel PriceModel { get; set; }
        public class DescribeRatePlanPriceResponseBodyPriceModel : TeaModel {
            [NameInMap("RatePlan")]
            [Validation(Required=false)]
            public DescribeRatePlanPriceResponseBodyPriceModelRatePlan RatePlan { get; set; }
            public class DescribeRatePlanPriceResponseBodyPriceModelRatePlan : TeaModel {
                [NameInMap("PlanPriceList")]
                [Validation(Required=false)]
                public List<DescribeRatePlanPriceResponseBodyPriceModelRatePlanPlanPriceList> PlanPriceList { get; set; }
                public class DescribeRatePlanPriceResponseBodyPriceModelRatePlanPlanPriceList : TeaModel {
                    [NameInMap("AccelerateType")]
                    [Validation(Required=false)]
                    public string AccelerateType { get; set; }

                    [NameInMap("ChargeType")]
                    [Validation(Required=false)]
                    public string ChargeType { get; set; }

                    [NameInMap("Coverages")]
                    [Validation(Required=false)]
                    public string Coverages { get; set; }

                    [NameInMap("CrossborderTraffic")]
                    [Validation(Required=false)]
                    public string CrossborderTraffic { get; set; }

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("DcdnPlan")]
                    [Validation(Required=false)]
                    public string DcdnPlan { get; set; }

                    [NameInMap("DiscountPrice")]
                    [Validation(Required=false)]
                    public float? DiscountPrice { get; set; }

                    [NameInMap("EdgeCompute")]
                    [Validation(Required=false)]
                    public string EdgeCompute { get; set; }

                    [NameInMap("EdgeDdos4Layer")]
                    [Validation(Required=false)]
                    public string EdgeDdos4Layer { get; set; }

                    [NameInMap("EdgeDdos4LayerIntl")]
                    [Validation(Required=false)]
                    public string EdgeDdos4LayerIntl { get; set; }

                    [NameInMap("EdgeDdos7Layer")]
                    [Validation(Required=false)]
                    public string EdgeDdos7Layer { get; set; }

                    [NameInMap("EdgeDdosInstanceCn")]
                    [Validation(Required=false)]
                    public string EdgeDdosInstanceCn { get; set; }

                    [NameInMap("EdgeDdosInstanceIntl")]
                    [Validation(Required=false)]
                    public string EdgeDdosInstanceIntl { get; set; }

                    [NameInMap("EdgeLb4Layer")]
                    [Validation(Required=false)]
                    public string EdgeLb4Layer { get; set; }

                    [NameInMap("EdgeLb4LayerIntl")]
                    [Validation(Required=false)]
                    public string EdgeLb4LayerIntl { get; set; }

                    [NameInMap("EdgeLb7Layer")]
                    [Validation(Required=false)]
                    public string EdgeLb7Layer { get; set; }

                    [NameInMap("EdgeWaf")]
                    [Validation(Required=false)]
                    public string EdgeWaf { get; set; }

                    [NameInMap("EdgeWafInstance")]
                    [Validation(Required=false)]
                    public string EdgeWafInstance { get; set; }

                    [NameInMap("Layer4Traffic")]
                    [Validation(Required=false)]
                    public string Layer4Traffic { get; set; }

                    [NameInMap("Layer4TrafficIntl")]
                    [Validation(Required=false)]
                    public string Layer4TrafficIntl { get; set; }

                    [NameInMap("PlanName")]
                    [Validation(Required=false)]
                    public string PlanName { get; set; }

                    [NameInMap("PlanStatus")]
                    [Validation(Required=false)]
                    public string PlanStatus { get; set; }

                    [NameInMap("PlanTraffic")]
                    [Validation(Required=false)]
                    public string PlanTraffic { get; set; }

                    [NameInMap("PlanType")]
                    [Validation(Required=false)]
                    public string PlanType { get; set; }

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public float? Price { get; set; }

                    [NameInMap("TotalPrice")]
                    [Validation(Required=false)]
                    public float? TotalPrice { get; set; }

                }

            }

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public DescribeRatePlanPriceResponseBodyPriceModelRule Rule { get; set; }
            public class DescribeRatePlanPriceResponseBodyPriceModelRule : TeaModel {
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<DescribeRatePlanPriceResponseBodyPriceModelRuleRuleList> RuleList { get; set; }
                public class DescribeRatePlanPriceResponseBodyPriceModelRuleRuleList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RuleDescId")]
                    [Validation(Required=false)]
                    public long? RuleDescId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>50423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

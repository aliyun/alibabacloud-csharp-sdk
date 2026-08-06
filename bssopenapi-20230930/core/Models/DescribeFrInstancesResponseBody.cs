// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeFrInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeFrInstancesResponseBodyData> Data { get; set; }
        public class DescribeFrInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icloudtest</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("AutoPurchase")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataAutoPurchase AutoPurchase { get; set; }
            public class DescribeFrInstancesResponseBodyDataAutoPurchase : TeaModel {
                [NameInMap("AlreadyAutoPurchase")]
                [Validation(Required=false)]
                public bool? AlreadyAutoPurchase { get; set; }

                [NameInMap("SettingAutoPurchase")]
                [Validation(Required=false)]
                public bool? SettingAutoPurchase { get; set; }

                [NameInMap("SupportAutoPurchase")]
                [Validation(Required=false)]
                public bool? SupportAutoPurchase { get; set; }

            }

            /// <summary>
            /// <para>The capacity type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Total decrement</para>
            /// </summary>
            [NameInMap("CapacitiyTypeName")]
            [Validation(Required=false)]
            public string CapacitiyTypeName { get; set; }

            /// <summary>
            /// <para>The capacity type.</para>
            /// </summary>
            [NameInMap("CapacityType")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataCapacityType CapacityType { get; set; }
            public class DescribeFrInstancesResponseBodyDataCapacityType : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deadlineAcc</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Total decrement</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The capacity type code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deadlineAcc</para>
            /// </summary>
            [NameInMap("CapacityTypeCode")]
            [Validation(Required=false)]
            public string CapacityTypeCode { get; set; }

            /// <summary>
            /// <para>The commodity.</para>
            /// </summary>
            [NameInMap("Commodity")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataCommodity Commodity { get; set; }
            public class DescribeFrInstancesResponseBodyDataCommodity : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slb_albcubag_dp_cn</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALB Resource Plan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pts</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Performance Testing</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The current capacity base unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("CurrCapacityBaseUnit")]
            [Validation(Required=false)]
            public string CurrCapacityBaseUnit { get; set; }

            /// <summary>
            /// <para>The current capacity base value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.000000</para>
            /// </summary>
            [NameInMap("CurrCapacityBaseValue")]
            [Validation(Required=false)]
            public string CurrCapacityBaseValue { get; set; }

            /// <summary>
            /// <para>The current capacity display unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("CurrCapacityViewUnit")]
            [Validation(Required=false)]
            public string CurrCapacityViewUnit { get; set; }

            /// <summary>
            /// <para>The current capacity display value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.000000</para>
            /// </summary>
            [NameInMap("CurrCapacityViewValue")]
            [Validation(Required=false)]
            public string CurrCapacityViewValue { get; set; }

            /// <summary>
            /// <para>The commitment cycle.</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataCycleType CycleType { get; set; }
            public class DescribeFrInstancesResponseBodyDataCycleType : TeaModel {
                /// <summary>
                /// <para>The commitment cycle code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hour</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The commitment cycle name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hour</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The commitment cycle code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("CycleTypeCode")]
            [Validation(Required=false)]
            public string CycleTypeCode { get; set; }

            /// <summary>
            /// <para>The commitment cycle name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("CycleTypeName")]
            [Validation(Required=false)]
            public string CycleTypeName { get; set; }

            /// <summary>
            /// <para>The list of deductible regions.</para>
            /// </summary>
            [NameInMap("DeductRegions")]
            [Validation(Required=false)]
            public List<DescribeFrInstancesResponseBodyDataDeductRegions> DeductRegions { get; set; }
            public class DescribeFrInstancesResponseBodyDataDeductRegions : TeaModel {
                /// <summary>
                /// <para>The deductible region code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The deductible region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("EnableDeductRule")]
            [Validation(Required=false)]
            public bool? EnableDeductRule { get; set; }

            /// <summary>
            /// <para>Indicates whether exchange is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableExchange")]
            [Validation(Required=false)]
            public bool? EnableExchange { get; set; }

            /// <summary>
            /// <para>Indicates whether renewal is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableRenew")]
            [Validation(Required=false)]
            public bool? EnableRenew { get; set; }

            /// <summary>
            /// <para>Indicates whether upgrade is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableUpgrade")]
            [Validation(Required=false)]
            public bool? EnableUpgrade { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710604800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The exchange commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ExchangeCommodityCode")]
            [Validation(Required=false)]
            public string ExchangeCommodityCode { get; set; }

            /// <summary>
            /// <para>The initial capacity base unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("InitCapacityBaseUnit")]
            [Validation(Required=false)]
            public string InitCapacityBaseUnit { get; set; }

            /// <summary>
            /// <para>The initial capacity base value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.000000</para>
            /// </summary>
            [NameInMap("InitCapacityBaseValue")]
            [Validation(Required=false)]
            public string InitCapacityBaseValue { get; set; }

            /// <summary>
            /// <para>The initial capacity display unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("InitCapacityViewUnit")]
            [Validation(Required=false)]
            public string InitCapacityViewUnit { get; set; }

            /// <summary>
            /// <para>The initial capacity display value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.000000</para>
            /// </summary>
            [NameInMap("InitCapacityViewValue")]
            [Validation(Required=false)]
            public string InitCapacityViewValue { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb_cubag*******</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The period capacity display unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("PeriodCapacityViewUnit")]
            [Validation(Required=false)]
            public string PeriodCapacityViewUnit { get; set; }

            /// <summary>
            /// <para>The period capacity display value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.000000</para>
            /// </summary>
            [NameInMap("PeriodCapacityViewValue")]
            [Validation(Required=false)]
            public string PeriodCapacityViewValue { get; set; }

            /// <summary>
            /// <para>The period time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("PeriodTime")]
            [Validation(Required=false)]
            public string PeriodTime { get; set; }

            /// <summary>
            /// <para>The product.</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataProduct Product { get; set; }
            public class DescribeFrInstancesResponseBodyDataProduct : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slb</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Server Load Balancer</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pts</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Performance Testing</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The purchase time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678939036000</para>
            /// </summary>
            [NameInMap("PurchaseTime")]
            [Validation(Required=false)]
            public long? PurchaseTime { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The specification.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The effective period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678939035000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataStatus Status { get; set; }
            public class DescribeFrInstancesResponseBodyDataStatus : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>valid</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The resource status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The resource status name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Valid</para>
            /// </summary>
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// <para>The template.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public DescribeFrInstancesResponseBodyDataTemplate Template { get; set; }
            public class DescribeFrInstancesResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alb_cubag*******</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chinese mainland regions</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FPT_armsappbag_deadlineAcc_bj</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new_test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The periodic capacity base unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CU</para>
            /// </summary>
            [NameInMap("periodCapacityBaseUnit")]
            [Validation(Required=false)]
            public string PeriodCapacityBaseUnit { get; set; }

            /// <summary>
            /// <para>The periodic capacity base value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.000000</para>
            /// </summary>
            [NameInMap("periodCapacityBaseValue")]
            [Validation(Required=false)]
            public string PeriodCapacityBaseValue { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

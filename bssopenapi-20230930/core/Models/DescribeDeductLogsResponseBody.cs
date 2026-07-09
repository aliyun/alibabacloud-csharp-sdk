// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeDeductLogsResponseBody : TeaModel {
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
        public List<DescribeDeductLogsResponseBodyData> Data { get; set; }
        public class DescribeDeductLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1929817951466001</para>
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

            /// <summary>
            /// <para>The deducted commodity.</para>
            /// </summary>
            [NameInMap("BillingCommodity")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataBillingCommodity BillingCommodity { get; set; }
            public class DescribeDeductLogsResponseBodyDataBillingCommodity : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>snapshot</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云服务器ECS-快照</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The deducted commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>snapshot</para>
            /// </summary>
            [NameInMap("BillingCommodityCode")]
            [Validation(Required=false)]
            public string BillingCommodityCode { get; set; }

            /// <summary>
            /// <para>The deducted commodity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云服务器ECS-快照</para>
            /// </summary>
            [NameInMap("BillingCommodityName")]
            [Validation(Required=false)]
            public string BillingCommodityName { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679036400000</para>
            /// </summary>
            [NameInMap("BillingEndTime")]
            [Validation(Required=false)]
            public long? BillingEndTime { get; set; }

            /// <summary>
            /// <para>The deduction instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("BillingInstanceId")]
            [Validation(Required=false)]
            public string BillingInstanceId { get; set; }

            /// <summary>
            /// <para>The deduction billable item.</para>
            /// </summary>
            [NameInMap("BillingPriceField")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataBillingPriceField BillingPriceField { get; set; }
            public class DescribeDeductLogsResponseBodyDataBillingPriceField : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Storage</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>零折使用容量</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The deduction billable item code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Storage</para>
            /// </summary>
            [NameInMap("BillingPriceFieldCode")]
            [Validation(Required=false)]
            public string BillingPriceFieldCode { get; set; }

            /// <summary>
            /// <para>The deduction billable item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>零折使用容量</para>
            /// </summary>
            [NameInMap("BillingPriceFieldName")]
            [Validation(Required=false)]
            public string BillingPriceFieldName { get; set; }

            /// <summary>
            /// <para>The effective period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679032800000</para>
            /// </summary>
            [NameInMap("BillingStartTime")]
            [Validation(Required=false)]
            public long? BillingStartTime { get; set; }

            /// <summary>
            /// <para>The display unit of the capacity after deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("CapacityAfterDeductViewUnit")]
            [Validation(Required=false)]
            public string CapacityAfterDeductViewUnit { get; set; }

            /// <summary>
            /// <para>The display value of the capacity after deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23.896484</para>
            /// </summary>
            [NameInMap("CapacityAfterDeductViewValue")]
            [Validation(Required=false)]
            public string CapacityAfterDeductViewValue { get; set; }

            /// <summary>
            /// <para>The display unit of the capacity before deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("CapacityBeforeDeductViewUnit")]
            [Validation(Required=false)]
            public string CapacityBeforeDeductViewUnit { get; set; }

            /// <summary>
            /// <para>The display value of the capacity before deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.000000</para>
            /// </summary>
            [NameInMap("CapacityBeforeDeductViewValue")]
            [Validation(Required=false)]
            public string CapacityBeforeDeductViewValue { get; set; }

            /// <summary>
            /// <para>The display unit of the deducted capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("CapacityDeductedViewUnit")]
            [Validation(Required=false)]
            public string CapacityDeductedViewUnit { get; set; }

            /// <summary>
            /// <para>The display value of the deducted capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16.103515</para>
            /// </summary>
            [NameInMap("CapacityDeductedViewValue")]
            [Validation(Required=false)]
            public string CapacityDeductedViewValue { get; set; }

            /// <summary>
            /// <para>The capacity type.</para>
            /// </summary>
            [NameInMap("CapacityType")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataCapacityType CapacityType { get; set; }
            public class DescribeDeductLogsResponseBodyDataCapacityType : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>absolute</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>总量恒定型</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The capacity type code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>absolute</para>
            /// </summary>
            [NameInMap("CapacityTypeCode")]
            [Validation(Required=false)]
            public string CapacityTypeCode { get; set; }

            /// <summary>
            /// <para>The capacity type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>总量恒定型</para>
            /// </summary>
            [NameInMap("CapacityTypeName")]
            [Validation(Required=false)]
            public string CapacityTypeName { get; set; }

            /// <summary>
            /// <para>The commodity.</para>
            /// </summary>
            [NameInMap("Commodity")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataCommodity Commodity { get; set; }
            public class DescribeDeductLogsResponseBodyDataCommodity : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ossbag</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>对象存储OSS资源包(包月)</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ossbag</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>对象存储OSS资源包(包月)</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The commitment cycle.</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataCycleType CycleType { get; set; }
            public class DescribeDeductLogsResponseBodyDataCycleType : TeaModel {
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
                /// <para>小时</para>
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
            /// <para>小时</para>
            /// </summary>
            [NameInMap("CycleTypeName")]
            [Validation(Required=false)]
            public string CycleTypeName { get; set; }

            /// <summary>
            /// <para>The deduction time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679039572000</para>
            /// </summary>
            [NameInMap("DeductTime")]
            [Validation(Required=false)]
            public long? DeductTime { get; set; }

            /// <summary>
            /// <para>The deduction factor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Factor")]
            [Validation(Required=false)]
            public string Factor { get; set; }

            /// <summary>
            /// <para>The ID of the account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("InstanceBelongAccountId")]
            [Validation(Required=false)]
            public long? InstanceBelongAccountId { get; set; }

            /// <summary>
            /// <para>The name of the account to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icloudtest</para>
            /// </summary>
            [NameInMap("InstanceBelongAccountName")]
            [Validation(Required=false)]
            public string InstanceBelongAccountName { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSSBAG-cn-****s</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The display unit of the metering amount after deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Byte</para>
            /// </summary>
            [NameInMap("MeasureAfterDeductViewUnit")]
            [Validation(Required=false)]
            public string MeasureAfterDeductViewUnit { get; set; }

            /// <summary>
            /// <para>The display value of the metering amount after deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MeasureAfterDeductViewValue")]
            [Validation(Required=false)]
            public string MeasureAfterDeductViewValue { get; set; }

            /// <summary>
            /// <para>The display unit of the metering amount before deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("MeasureBeforeDeductViewUnit")]
            [Validation(Required=false)]
            public string MeasureBeforeDeductViewUnit { get; set; }

            /// <summary>
            /// <para>The display value of the metering amount before deduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16.103515</para>
            /// </summary>
            [NameInMap("MeasureBeforeDeductViewValue")]
            [Validation(Required=false)]
            public string MeasureBeforeDeductViewValue { get; set; }

            /// <summary>
            /// <para>The display unit of the deducted metering amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("MeasureDeductedViewUnit")]
            [Validation(Required=false)]
            public string MeasureDeductedViewUnit { get; set; }

            /// <summary>
            /// <para>The display value of the deducted metering amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16.103515</para>
            /// </summary>
            [NameInMap("MeasureDeductedViewValue")]
            [Validation(Required=false)]
            public string MeasureDeductedViewValue { get; set; }

            /// <summary>
            /// <para>The product.</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataProduct Product { get; set; }
            public class DescribeDeductLogsResponseBodyDataProduct : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>对象存储</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>对象存储</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The deduction account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("RelationAccountId")]
            [Validation(Required=false)]
            public long? RelationAccountId { get; set; }

            /// <summary>
            /// <para>The deduction account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icloudtest</para>
            /// </summary>
            [NameInMap("RelationAccountName")]
            [Validation(Required=false)]
            public string RelationAccountName { get; set; }

            /// <summary>
            /// <para>The template.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public DescribeDeductLogsResponseBodyDataTemplate Template { get; set; }
            public class DescribeDeductLogsResponseBodyDataTemplate : TeaModel {
                /// <summary>
                /// <para>The property code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FPT_ossbag********</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>标准存储包</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FPT_ossbag********</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标准存储包</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

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
        /// <para>DF58589C-A06C-4224-8615-7797E6474FA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Alibaba Cloud Global Accelerator (GA) instance attached to the bandwidth plan.</para>
        /// </summary>
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<string> Accelerators { get; set; }

        /// <summary>
        /// <para>The bandwidth value of the bandwidth plan. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The bandwidth type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: standard acceleration bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>Enhanced</b>: enhanced acceleration bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>Advanced</b>: premium acceleration bandwidth.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The billable methods for the pay-as-you-go billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer.</description></item>
        /// <item><description><b>PayBY95</b>: pay-by-95th-percentile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>The interconnected area A of the cross-border acceleration bandwidth plan. The value is returned only as <b>China-mainland</b> (the Chinese mainland).</para>
        /// <para>This parameter is returned only on the Alibaba Cloud International Website (<a href="http://www.alibabacloud.com">www.alibabacloud.com</a>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>China-mainland</para>
        /// </summary>
        [NameInMap("CbnGeographicRegionIdA")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdA { get; set; }

        /// <summary>
        /// <para>The interconnected area B of the cross-border acceleration bandwidth plan. The value is returned only as <b>Global</b>.</para>
        /// <para>This parameter is returned only on the Chinese site (Chinese mainland).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("CbnGeographicRegionIdB")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdB { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b> (default): subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The timestamp when the bandwidth plan was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578966918000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The timestamp when the bandwidth plan expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1578966918000</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The name of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The minimum percentage for the pay-by-95th-percentile metering method. Valid values: <b>30</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// <para>The region ID of the Alibaba Cloud Global Accelerator (GA) instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B6DBBB0-2D01-4C6A-A384-4129266E6B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfnvueepcihjiq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b>: initialization.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: active.</para>
        /// </description></item>
        /// <item><description><para><b>binded</b>: attached.</para>
        /// </description></item>
        /// <item><description><para><b>binding</b>: being attached.</para>
        /// </description></item>
        /// <item><description><para><b>unbinding</b>: being disassociated.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: being updated.</para>
        /// </description></item>
        /// <item><description><para><b>finacialLocked</b>: locked due to overdue payment.</para>
        /// </description></item>
        /// <item><description><para><b>locked</b>: locked.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeBandwidthPackageResponseBodyTags> Tags { get; set; }
        public class DescribeBandwidthPackageResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: basic bandwidth plan.</para>
        /// </description></item>
        /// <item><description><para><b>CrossDomain</b>: cross-border acceleration bandwidth plan.</para>
        /// </description></item>
        /// </list>
        /// <para>Only <b>Basic</b> is returned on the Alibaba Cloud China Website (<a href="http://www.aliyun.com">www.aliyun.com</a>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

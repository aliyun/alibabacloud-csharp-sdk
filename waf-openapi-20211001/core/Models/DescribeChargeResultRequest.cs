// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeChargeResultRequest : TeaModel {
        /// <summary>
        /// <para>The billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: calculates the billing result for one year</description></item>
        /// <item><description><b>Month</b>: calculates the billing result for one month</description></item>
        /// <item><description><b>Day</b>: calculates the billing result for one day</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("ChargeCycle")]
        [Validation(Required=false)]
        public string ChargeCycle { get; set; }

        /// <summary>
        /// <para>The list of billing modules to be calculated.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChargeModules")]
        [Validation(Required=false)]
        public List<DescribeChargeResultRequestChargeModules> ChargeModules { get; set; }
        public class DescribeChargeResultRequestChargeModules : TeaModel {
            /// <summary>
            /// <para>The billing module code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domainCount</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The usage of the billing module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public long? Usage { get; set; }

            /// <summary>
            /// <para>The usage of the billing module, which supports integers and decimals. If the billing module is log storage capacity, the usage supports up to one decimal place, such as 10.5. This parameter is optional and has no default value. If this parameter is specified, it takes precedence even if the value is 0. If this parameter is not specified, Usage is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.5</para>
            /// </summary>
            [NameInMap("UsageDecimal")]
            [Validation(Required=false)]
            public double? UsageDecimal { get; set; }

        }

        /// <summary>
        /// <para>The metering unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SeCU</para>
        /// </summary>
        [NameInMap("ChargeUnit")]
        [Validation(Required=false)]
        public string ChargeUnit { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>POSTPAY</b>: pay-as-you-go WAF instances</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

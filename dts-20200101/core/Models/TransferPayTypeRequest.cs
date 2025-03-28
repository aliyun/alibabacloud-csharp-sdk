// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class TransferPayTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically renew the DTS instance when it expires. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: does not automatically renew the DTS instance when it expires. This is the default value.</description></item>
        /// <item><description><b>true</b>: automatically renews the DTS instance when it expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The subscription length.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>Period</b> parameter is set to <b>Year</b>, the value range is <b>1</b> to <b>5</b>.</description></item>
        /// <item><description>If the <b>Period</b> parameter is set to <b>Month</b>, the value range is <b>1</b> to <b>60</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify this parameter only if you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public string BuyCount { get; set; }

        /// <summary>
        /// <para>The new billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization or change tracking task. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>o4nh3g7jg56****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The new instance class of the DTS instance. You can call the <a href="https://help.aliyun.com/document_detail/208925.html">DescribeDtsJobDetail</a> operation to query the original instance class of the DTS instance.</para>
        /// <list type="bullet">
        /// <item><description>DTS supports the following instance classes for a data migration instance: <b>xxlarge</b>, <b>xlarge</b>, <b>large</b>, <b>medium</b>, and <b>small</b>.</description></item>
        /// <item><description>DTS supports the following instance classes for a data synchronization instance: <b>large</b>, <b>medium</b>, <b>small</b>, and <b>micro</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the test performance of each instance class, see <a href="https://help.aliyun.com/document_detail/26606.html">Specifications of data migration instances</a> and <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization channels</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>small</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The maximum number of DUs in a serverless instance. Valid values: 2, 4, 8, and 16.</para>
        /// <remarks>
        /// <para> This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public int? MaxDu { get; set; }

        /// <summary>
        /// <para>The minimum number of DTS Units (DUs) in a serverless instance. Valid values: 1, 2, 4, 8, and 16.</para>
        /// <remarks>
        /// <para> This feature is not supported. Do not specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public int? MinDu { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b> (default value)</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify this parameter only if you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the region where the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

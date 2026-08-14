// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class TransferPayTypeRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If Period is set to <b>Year</b>, valid values are <b>1</b> to <b>5</b>.</description></item>
        /// <item><description>If Period is set to <b>Month</b>, valid values are <b>1</b> to <b>60</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when ChargeType is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public string BuyCount { get; set; }

        /// <summary>
        /// <para>The billing method after conversion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.
        /// &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description><b>sync_serverless</b>: pay-as-you-go Serverless..</description></item>
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
        /// <para>The ID of the data synchronization or change tracking task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>o4nh3g7jg56****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The maximum number of DUs for the Serverless instance. Valid values: 2, 4, 8, and 16.
        /// &lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.
        /// &lt;props=&quot;china&quot;&gt;
        /// This parameter is valid and required only when ChargeType is set to <b>sync_serverless</b>..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public int? MaxDu { get; set; }

        /// <summary>
        /// <para>The minimum number of DTS Units (DUs) for the Serverless instance. Valid values: 1, 2, 4, 8, and 16.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <remarks>
        /// <para>This feature is currently not supported. Do not specify this parameter.
        /// &lt;props=&quot;china&quot;&gt;
        /// This parameter is valid and required only when ChargeType is set to <b>sync_serverless</b>..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinDu")]
        [Validation(Required=false)]
        public int? MinDu { get; set; }

        /// <summary>
        /// <para>The billing method of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: annual subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when ChargeType is set to <b>PrePaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
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

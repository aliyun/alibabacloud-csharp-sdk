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
        /// <para>The billing method that you want to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The billing method of subscription instances cannot be changed to pay-as-you-go. To prevent resource waste, determine whether you need to change the billing method of your resources.</description></item>
        /// <item><description>If you do not need to change the billing method, specify the current billing method.</description></item>
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

        [NameInMap("MaxDu")]
        [Validation(Required=false)]
        public int? MaxDu { get; set; }

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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

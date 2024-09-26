// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The subscription duration of the DTS instance after renewal. Default value: 1.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>Period</b> parameter is set to <b>Year</b>, the valid values are <b>1 to 5</b>.</description></item>
        /// <item><description>If the <b>Period</b> parameter is set to <b>Month</b>, the valid values are <b>1 to 60</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public string BuyCount { get; set; }

        /// <summary>
        /// <para>The billing method of the DTS instance. Set the value to <b>PREPAY</b>, which indicates the subscription billing method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization or change tracking task. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qi0r643lc31****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The billing cycle of the DTS instance after renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: annual subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the DTS instance. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
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

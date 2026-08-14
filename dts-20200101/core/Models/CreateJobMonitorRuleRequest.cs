// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateJobMonitorRuleRequest : TeaModel {
        /// <summary>
        /// <para>The threshold for triggering an alert.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>Type</b> is set to <b>delay</b>, the unit is seconds and the value must be an integer. Set the threshold based on your business requirements. A value of 10 or greater is recommended to avoid alert fluctuations caused by network issues or database loads.</para>
        /// </description></item>
        /// <item><description><para>If <b>Type</b> is set to <b>full_timeout</b>, the unit is hours and the value must be an integer.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>Type</b> is set to <b>delay</b> or <b>full_timeout</b> and <b>State</b> is set to <b>Y</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to obtain the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i03e3zty16i****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The alert threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NoticeValue")]
        [Validation(Required=false)]
        public int? NoticeValue { get; set; }

        /// <summary>
        /// <para>The statistical period of the incremental verification task. Unit: minutes.</para>
        /// <remarks>
        /// <para>Valid values: 1, 5, 10, and 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers of alert contacts, separated by commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only on the China site (aliyun.com) and only for the Chinese mainland mobile phone numbers. A maximum of 10 mobile phone numbers can be specified.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The international site does not support SMS-based alerting. You can only <a href="https://help.aliyun.com/document_detail/175876.html">set alert rules for DTS tasks through the CloudMonitor monitoring platform</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
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

        /// <summary>
        /// <para>Specifies whether to enable the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable the alert rule.</description></item>
        /// <item><description><b>N</b>: Disable the alert rule.</description></item>
        /// </list>
        /// <para>Default value: <b>Y</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The number of statistical periods for the incremental verification task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

        /// <summary>
        /// <para>The type of the alert metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>delay</b>: the <b>Latency</b> metric.</description></item>
        /// <item><description><b>error</b>: the <b>Migration Status</b> metric.</description></item>
        /// <item><description><b>full_timeout</b>: the <b>Full Migration Duration</b> metric.</description></item>
        /// </list>
        /// <para>Default value: <b>error</b>. This parameter must be manually specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

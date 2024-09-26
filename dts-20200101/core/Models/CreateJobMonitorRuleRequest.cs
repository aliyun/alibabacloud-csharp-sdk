// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateJobMonitorRuleRequest : TeaModel {
        /// <summary>
        /// <para>The threshold for triggering latency alerts.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>Type</b> parameter is set to <b>delay</b>, the threshold must be an integer. You can set the threshold based on your requirements. To prevent jitters caused by network and database overloads, we recommend that you set the threshold to more than 10 seconds. Unit: seconds.</description></item>
        /// <item><description>If the <b>Type</b> parameter is set to <b>full_timeout</b>, the threshold must be an integer. Unit: hours.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the <b>Type</b> parameter is set to <b>delay</b> or <b>full_timeout</b> and the <b>State</b> parameter is set to <b>Y</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DelayRuleTime")]
        [Validation(Required=false)]
        public long? DelayRuleTime { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
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
        /// <para>The statistical period of the incremental data verification task. Unit: minutes.</para>
        /// <remarks>
        /// <para> Valid values: 1, 3, 5, and 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The mobile numbers that receive alert notifications. Separate multiple mobile numbers with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for users of the China site (aliyun.com). Only mobile numbers in the Chinese mainland are supported. You can specify up to 10 mobile numbers.</description></item>
        /// <item><description>Users of the international site (alibabacloud.com) cannot receive alerts by using mobile phones, but can <a href="https://help.aliyun.com/document_detail/175876.html">configure alert rules for DTS tasks in the CloudMonitor console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1361234****,1371234****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

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

        /// <summary>
        /// <para>Specifies whether to enable the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: enables the alert rule.</description></item>
        /// <item><description><b>N</b>: disables the alert rule.</description></item>
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
        /// <para>The number of statistical periods of the incremental data verification task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

        /// <summary>
        /// <para>The metric that is used to monitor the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>delay</b>: the <b>Latency</b> metric.</description></item>
        /// <item><description><b>error</b>: the <b>Status</b> metric.</description></item>
        /// <item><description><b>full_timeout</b>: the <b>Full Timeout</b> metric.</description></item>
        /// </list>
        /// <para>Default value: <b>error</b>. You must manually set this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The start of the time range for scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CronBeginDate_test</para>
        /// </summary>
        [NameInMap("CronBeginDate")]
        [Validation(Required=false)]
        public string CronBeginDate { get; set; }

        /// <summary>
        /// <para>The end of the time range for scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CronEndDate_test</para>
        /// </summary>
        [NameInMap("CronEndDate")]
        [Validation(Required=false)]
        public string CronEndDate { get; set; }

        /// <summary>
        /// <para>The cron expression for timed scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CronStr_test</para>
        /// </summary>
        [NameInMap("CronStr")]
        [Validation(Required=false)]
        public string CronStr { get; set; }

        /// <summary>
        /// <para>The type of the scheduling cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MINUTE</b>: scheduling by minute</description></item>
        /// <item><description><b>HOUR</b>: scheduling by hour</description></item>
        /// <item><description><b>DAY</b>: scheduling by day</description></item>
        /// <item><description><b>WEEK</b>: scheduling by week</description></item>
        /// <item><description><b>MONTH</b>: scheduling by month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        /// <summary>
        /// <para>The ID of the task flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7***</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The event scheduling configuration. The value of this parameter is a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScheduleParam_test</para>
        /// </summary>
        [NameInMap("ScheduleParam")]
        [Validation(Required=false)]
        public string ScheduleParam { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable scheduling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disable</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("ScheduleSwitch")]
        [Validation(Required=false)]
        public bool? ScheduleSwitch { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>: To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The time zone. The default time zone is UTC+8 (Asia/Shanghai).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZoneId")]
        [Validation(Required=false)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// <para>The mode in which the task flow is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cron</b>: The task flow is triggered based on timed scheduling.</description></item>
        /// <item><description><b>Event</b>: The task flow is triggered by events.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Event</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}

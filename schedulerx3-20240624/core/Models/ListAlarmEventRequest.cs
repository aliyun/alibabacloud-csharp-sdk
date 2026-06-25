// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListAlarmEventRequest : TeaModel {
        /// <summary>
        /// <para>The channel for sending alarm notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>sms</c>: SMS</para>
        /// </description></item>
        /// <item><description><para><c>mail</c>: Email</para>
        /// </description></item>
        /// <item><description><para><c>phone</c>: Phone call</para>
        /// </description></item>
        /// <item><description><para><c>webhook</c>: Webhook</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>webhook</para>
        /// </summary>
        [NameInMap("AlarmChannel")]
        [Validation(Required=false)]
        public string AlarmChannel { get; set; }

        /// <summary>
        /// <para>The delivery status of the alarm notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The notification delivery succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The notification delivery failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AlarmStatus")]
        [Validation(Required=false)]
        public string AlarmStatus { get; set; }

        /// <summary>
        /// <para>The type of the alarm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b><c>schedulerx3_no_designate_machine_alarm</c></b>: The Designated Machine is unavailable.</para>
        /// </description></item>
        /// <item><description><para><b><c>schedulerx3_all_busy_alarm</c></b>: All available machines are busy.</para>
        /// </description></item>
        /// <item><description><para><b><c>schedulerx3_no_machine_alarm</c></b>: No machines are available to run the job.</para>
        /// </description></item>
        /// <item><description><para><b><c>schedulerx3_timeout_alarm</c></b>: The job timed out.</para>
        /// </description></item>
        /// <item><description><para><b><c>schedulerx3_fail_alarm</c></b>: The job failed to run.</para>
        /// </description></item>
        /// <item><description><para><b><c>schedulerx3_job_success_notice</c></b>: The job ran successfully.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx3_fail_alarm</para>
        /// </summary>
        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range for querying events. This value is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731636011558</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-job</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Set to true to return results in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The start of the time range for querying events. This value is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690419316000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

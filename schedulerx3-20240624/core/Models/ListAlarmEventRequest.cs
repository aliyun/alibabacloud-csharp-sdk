// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListAlarmEventRequest : TeaModel {
        /// <summary>
        /// <para>The alert channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>sms</c>: SMS.</description></item>
        /// <item><description><c>mail</c>: Email.</description></item>
        /// <item><description><c>phone</c>: Phone call.</description></item>
        /// <item><description><c>webhook</c>: Webhook.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>webhook</para>
        /// </summary>
        [NameInMap("AlarmChannel")]
        [Validation(Required=false)]
        public string AlarmChannel { get; set; }

        /// <summary>
        /// <para>The alert status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The alert message is sent successfully.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The alert message fails to be sent.</para>
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
        /// <para>The alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b><c>schedulerx3_no_designate_machine_alarm</c></b>: Unavailable designated machine alert.</description></item>
        /// <item><description><b><c>schedulerx3_all_busy_alarm</c></b>: All machines busy alert.</description></item>
        /// <item><description><b><c>schedulerx3_no_machine_alarm</c></b>: No available machine alert.</description></item>
        /// <item><description><b><c>schedulerx3_timeout_alarm</c></b>: Job timeout alert.</description></item>
        /// <item><description><b><c>schedulerx3_fail_alarm</c></b>: Job execution failure alert.</description></item>
        /// <item><description><b><c>schedulerx3_job_success_notice</c></b>: Job execution success notice.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx3_fail_alarm</para>
        /// </summary>
        [NameInMap("AlarmType")]
        [Validation(Required=false)]
        public string AlarmType { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the retrieved events. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731636011558</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The job name.</para>
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
        /// <para>Specifies whether to sort the results in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The start time of the retrieved events. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690419316000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

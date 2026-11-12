// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetLogRequest : TeaModel {
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
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721636220</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The job execution ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1310630367761285120</para>
        /// </summary>
        [NameInMap("JobExecutionId")]
        [Validation(Required=false)]
        public string JobExecutionId { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello word</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The log level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The LineNum.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LineNum")]
        [Validation(Required=false)]
        public int? LineNum { get; set; }

        /// <summary>
        /// <para>The log ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>344008</para>
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public long? LogId { get; set; }

        /// <summary>
        /// <para>The offset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the results in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Sorts the results in descending order.</description></item>
        /// <item><description><b>false</b>: Sorts the results in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        /// <summary>
        /// <para>The scheduling time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1696132800000</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721636220</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The worker address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("WorkerAddr")]
        [Validation(Required=false)]
        public string WorkerAddr { get; set; }

    }

}

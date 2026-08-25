// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoThrottleRulesAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The duration threshold of the anomaly that triggers automatic SQL throttling. The value must be a positive integer greater than or equal to 2. Unit: minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AbnormalDuration")]
        [Validation(Required=false)]
        public double? AbnormalDuration { get; set; }

        /// <summary>
        /// <para>The active sessions threshold.	</para>
        /// <list type="bullet">
        /// <item><description>If the relationship with the CPU utilization threshold is <b>OR</b>, the value must be greater than or equal to 16.</description></item>
        /// <item><description>If the relationship with the CPU utilization threshold is <b>AND</b>, the value must be greater than or equal to 2.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("ActiveSessions")]
        [Validation(Required=false)]
        public long? ActiveSessions { get; set; }

        /// <summary>
        /// <para>The end time of the throttling time window (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:59Z</para>
        /// </summary>
        [NameInMap("AllowThrottleEndTime")]
        [Validation(Required=false)]
        public string AllowThrottleEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the throttling time window (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("AllowThrottleStartTime")]
        [Validation(Required=false)]
        public string AllowThrottleStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to simultaneously kill abnormal SQL statements that are being executed.</para>
        /// <remarks>
        /// <para>Abnormal SQL statements are those that match the SQL templates to be throttled.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoKillSession")]
        [Validation(Required=false)]
        public bool? AutoKillSession { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The logical relationship between the CPU utilization threshold and the active sessions threshold. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AND</b>: both conditions must be met.</description></item>
        /// <item><description><b>OR</b>: either condition must be met.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OR</para>
        /// </summary>
        [NameInMap("CpuSessionRelation")]
        [Validation(Required=false)]
        public string CpuSessionRelation { get; set; }

        /// <summary>
        /// <para>The CPU utilization threshold. Valid values: 70% to 100%.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("CpuUsage")]
        [Validation(Required=false)]
        public double? CpuUsage { get; set; }

        /// <summary>
        /// <para>The database instance IDs.</para>
        /// <remarks>
        /// <para>The data format is JSONArray, such as <c>[\\&quot;Instance ID 1\\&quot;,\\&quot;Instance ID 2\\&quot;]</c>. Separate instance IDs with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;rm-2ze8g2am97624****\&quot;,\&quot;rm-2ze9xrhze0709****\&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The maximum throttling duration. The value must be a positive integer. Unit: minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxThrottleTime")]
        [Validation(Required=false)]
        public double? MaxThrottleTime { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous request.</para>
        /// <remarks>
        /// <para>An asynchronous call does not immediately return complete results. First, call this operation to obtain the <b>ResultId</b>. Then, use the returned <b>ResultId</b> to initiate the call again until <b>isFinish</b> is <b>true</b>, at which point the complete results are returned. This means that you must call this operation at least twice to obtain complete data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>async__507044db6c4eadfa2dab9b084e80****</para>
        /// </summary>
        [NameInMap("ResultId")]
        [Validation(Required=false)]
        public string ResultId { get; set; }

    }

}

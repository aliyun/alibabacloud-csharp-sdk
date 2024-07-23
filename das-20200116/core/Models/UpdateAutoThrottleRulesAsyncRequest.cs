// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoThrottleRulesAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The duration threshold for triggering automatic SQL throttling. Set this parameter to an integer that is greater than or equal to 2. Unit: minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AbnormalDuration")]
        [Validation(Required=false)]
        public double? AbnormalDuration { get; set; }

        /// <summary>
        /// <para>The threshold for the number of active sessions.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter and CpuUsage are in the <b>OR</b> relationship, set this parameter to an integer that is greater than or equal to 16.</description></item>
        /// <item><description>If this parameter and CpuUsage are in the <b>AND</b> relationship, set this parameter to an integer that is greater than or equal to 2.</description></item>
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
        /// <para>The end time of the throttling window. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:59Z</para>
        /// </summary>
        [NameInMap("AllowThrottleEndTime")]
        [Validation(Required=false)]
        public string AllowThrottleEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the throttling window. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("AllowThrottleStartTime")]
        [Validation(Required=false)]
        public string AllowThrottleStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to terminate abnormal SQL statements in execution at the same time. Valid values:</para>
        /// <remarks>
        /// <para> Abnormal SQL statements use the same template as the SQL statements to be throttled.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The logical relationship between the CPU utilization threshold and the maximum number of active sessions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AND</b></description></item>
        /// <item><description><b>OR</b></description></item>
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
        /// <para>The threshold for CPU utilization. Valid values: 70% to 100%.</para>
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
        /// <para> Set this parameter to a JSON array that consists of multiple instance IDs. Separate instance IDs with commas (,). Example: <c>[\\&quot;Instance ID1\\&quot;, \\&quot;Instance ID2\\&quot;]</c>.</para>
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
        /// <para>The maximum throttling duration. Set this parameter to a positive integer. Unit: minutes.</para>
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
        /// <para> You can leave this parameter empty when you call the operation to initiate the request for the first time, and use the value of this parameter contained in the response to the first request for subsequent requests.</para>
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

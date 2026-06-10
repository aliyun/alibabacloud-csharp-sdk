// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class AssignJobsRequest : TeaModel {
        /// <summary>
        /// <para>These numbers are displayed as the caller ID to the contact.</para>
        /// <remarks>
        /// <para>If unspecified, all available calling numbers are used.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12f3dd08-0c55-44ce-9b64-e69d35ed3a76</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the task is asynchronous.</para>
        /// <para>You can omit this parameter if you create jobs by calling this API. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsAsynchrony")]
        [Validation(Required=false)]
        public bool? IsAsynchrony { get; set; }

        /// <summary>
        /// <para>The ID of the data parsing task for the outbound call job.</para>
        /// <para>You can omit this parameter if you create jobs by calling this API.</para>
        /// <remarks>
        /// <para>If you create jobs by uploading a file, you must call the <c>CreateJobDataParsingTask</c> operation to obtain a value for this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("JobDataParsingTaskId")]
        [Validation(Required=false)]
        public string JobDataParsingTaskId { get; set; }

        /// <summary>
        /// <para>The job group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// <para>The job data, a JSON array where each object represents a contact. For formatting details, see the example.</para>
        /// <para>The array can contain up to 99 elements.</para>
        /// </summary>
        [NameInMap("JobsJson")]
        [Validation(Required=false)]
        public List<string> JobsJson { get; set; }

        /// <summary>
        /// <para>The roster type.</para>
        /// <para>If you create jobs by calling this API, you can omit this parameter. The default value is <c>json</c>. If you upload a contact list file, set this parameter to <c>excel</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>json</para>
        /// </summary>
        [NameInMap("RosterType")]
        [Validation(Required=false)]
        public string RosterType { get; set; }

        /// <summary>
        /// <para>The execution strategy for the job group.</para>
        /// <list type="bullet">
        /// <item><description><para><c>repeatBy</c>: The recurrence type. Valid values: <c>Once</c> (runs once), <c>Day</c> (repeats daily), <c>Week</c> (repeats weekly), and <c>Month</c> (repeats monthly).</para>
        /// </description></item>
        /// <item><description><para><c>startTime</c>: The start time of the strategy.</para>
        /// </description></item>
        /// <item><description><para><c>endTime</c>: The end time of the strategy.</para>
        /// </description></item>
        /// <item><description><para><c>workingTime</c>: The time windows during which calls can be made.</para>
        /// </description></item>
        /// <item><description><para><c>maxAttemptsPerDay</c>: The maximum daily call attempts per phone number.</para>
        /// </description></item>
        /// <item><description><para><c>minAttemptInterval</c>: The minimum interval between call retries, in minutes.</para>
        /// </description></item>
        /// <item><description><para><c>routingStrategy</c>: The number routing strategy. Valid values: <c>None</c> (no preference), <c>LocalFirst</c> (prioritizes numbers in the same city), and <c>LocalProvinceFirst</c> (prioritizes numbers in the same province).</para>
        /// </description></item>
        /// <item><description><para><c>repeatDays</c>: The specific days on which the job runs, based on the <c>repeatBy</c> type. If <c>repeatBy</c> is set to <c>Week</c>, <c>0</c> represents Sunday, and <c>1</c> through <c>6</c> represent Monday through Saturday. If <c>repeatBy</c> is set to <c>Month</c>, values from <c>1</c> to <c>31</c> represent the days of the month. If a month does not have a specified day (for example, February 30), the job is skipped for that month.</para>
        /// </description></item>
        /// <item><description><para><c>repeatable</c>: Specifies whether the job is recurring. Valid values are <c>true</c> and <c>false</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxAttemptsPerDay&quot;:&quot;3&quot;,&quot;minAttemptInterval&quot;:&quot;10&quot;,&quot;routingStrategy&quot;:&quot;LocalProvinceFirst&quot;,&quot;repeatDays&quot;:[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;],&quot;workingTime&quot;:[{&quot;beginTime&quot;:&quot;10:00:00&quot;,&quot;endTime&quot;:&quot;11:00:00&quot;},{&quot;beginTime&quot;:&quot;14:00:00&quot;,&quot;endTime&quot;:&quot;15:00:00&quot;}],&quot;repeatable&quot;:true,&quot;endTime&quot;:1707494400000,&quot;startTime&quot;:1706976000000,&quot;repeatBy&quot;:&quot;Week&quot;}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}

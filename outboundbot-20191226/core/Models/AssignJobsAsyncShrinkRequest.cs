// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class AssignJobsAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of calling numbers to be displayed to callees.</para>
        /// <remarks>
        /// <para>If you omit this parameter, the system uses all available calling numbers by default.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumberShrink { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12f3dd08-0c55-44ce-9b64-e69d35ed3a76</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the job group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>A JSON array containing job data. For the required format, see the example.</para>
        /// <para>Each JSON object in the array represents a job for a single contact.</para>
        /// </summary>
        [NameInMap("JobsJson")]
        [Validation(Required=false)]
        public string JobsJsonShrink { get; set; }

        /// <summary>
        /// <para>A JSON string that defines the job group execution strategy. This object has the following properties:</para>
        /// <list type="bullet">
        /// <item><description><c>repeatBy</c></description></item>
        /// </list>
        /// <para>Specifies the repetition frequency. Valid values include <c>Once</c> (does not repeat), <c>Day</c> (repeats daily), <c>Week</c> (repeats weekly), and <c>Month</c> (repeats monthly).</para>
        /// <list type="bullet">
        /// <item><description><c>startTime</c></description></item>
        /// </list>
        /// <para>The start time of the execution strategy.</para>
        /// <list type="bullet">
        /// <item><description><c>endTime</c></description></item>
        /// </list>
        /// <para>The end time of the execution strategy.</para>
        /// <list type="bullet">
        /// <item><description><c>workingTime</c></description></item>
        /// </list>
        /// <para>The time range during which outbound calls can be made.</para>
        /// <list type="bullet">
        /// <item><description><c>maxAttemptsPerDay</c></description></item>
        /// </list>
        /// <para>The maximum number of daily call attempts for a single phone number.</para>
        /// <list type="bullet">
        /// <item><description><c>minAttemptInterval</c></description></item>
        /// </list>
        /// <para>The minimum interval between retry attempts, in minutes.</para>
        /// <list type="bullet">
        /// <item><description><c>routingStrategy</c></description></item>
        /// </list>
        /// <para>The routing strategy for calling numbers. Valid values: <c>None</c> (not specified), <c>LocalFirst</c> (prioritizes numbers in the same city), and <c>LocalProvinceFirst</c> (prioritizes numbers in the same province).</para>
        /// <list type="bullet">
        /// <item><description><c>repeatDays</c></description></item>
        /// </list>
        /// <para>The days on which the job repeats. If <c>repeatBy</c> is set to <c>Week</c>, valid values are <c>0</c> for Sunday and <c>1</c> to <c>6</c> for Monday to Saturday. If <c>repeatBy</c> is set to <c>Month</c>, valid values are <c>1</c> to <c>31</c>. If a specified day does not exist in a given month (e.g., February 30), the job is skipped for that month.</para>
        /// <list type="bullet">
        /// <item><description><c>repeatable</c></description></item>
        /// </list>
        /// <para>Specifies whether to enable recurring jobs. Valid values: <c>true</c> and <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxAttemptsPerDay&quot;:&quot;3&quot;,&quot;minAttemptInterval&quot;:&quot;10&quot;,&quot;routingStrategy&quot;:&quot;LocalProvinceFirst&quot;,&quot;repeatDays&quot;:[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;],&quot;workingTime&quot;:[{&quot;beginTime&quot;:&quot;10:00:00&quot;,&quot;endTime&quot;:&quot;11:00:00&quot;},{&quot;beginTime&quot;:&quot;14:00:00&quot;,&quot;endTime&quot;:&quot;15:00:00&quot;}],&quot;repeatable&quot;:true,&quot;endTime&quot;:1707494400000,&quot;startTime&quot;:1706976000000,&quot;repeatBy&quot;:&quot;Week&quot;}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

    }

}

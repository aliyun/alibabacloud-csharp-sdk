// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateCycleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The time of the first execution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1650556800000</para>
        /// </summary>
        [NameInMap("FirstDateStr")]
        [Validation(Required=false)]
        public long? FirstDateStr { get; set; }

        /// <summary>
        /// <para>The interval period.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        /// <summary>
        /// <para>The extended information field.</para>
        /// <para>Note: This parameter is actually required. If this parameter is not specified, the API returns an error. The value is a JSON-formatted string that must contain at least the targetInfo array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;targetInfo&quot;: [
        ///             {
        ///                   &quot;type&quot;: &quot;groupId&quot;,
        ///                   &quot;name&quot;: &quot;TI HOST&quot;,
        ///                   &quot;target&quot;: 10597***
        ///             },
        ///             {
        ///                   &quot;type&quot;: &quot;groupId&quot;,
        ///                   &quot;name&quot;: &quot;expense HOST&quot;,
        ///                   &quot;target&quot;: 10597***
        ///             }
        ///       ]
        /// }</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The unit of the scan period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: day.</description></item>
        /// <item><description><b>hour</b>: hour.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The source from which the task is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console_batch</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The task end time, in hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TargetEndTime")]
        [Validation(Required=false)]
        public int? TargetEndTime { get; set; }

        /// <summary>
        /// <para>The task start time, in hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TargetStartTime")]
        [Validation(Required=false)]
        public int? TargetStartTime { get; set; }

        /// <summary>
        /// <para>The task name. This is a custom string used to identify the periodic scan task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_virus_scan</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: virus scan.</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan.</description></item>
        /// <item><description><b>EMG_VUL_SCHEDULE_SCAN</b>: emergency vulnerability scanning.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIRUS_VUL_SCHEDULE_SCAN</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}

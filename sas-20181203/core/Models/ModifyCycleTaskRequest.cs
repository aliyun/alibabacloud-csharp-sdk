// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCycleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task configuration.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCycleTaskList~~">DescribeCycleTaskList</a> operation to query the IDs of task configurations.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00cfa8161da093089e6804ba6a33****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the task.</description></item>
        /// <item><description><b>0</b>: disables the task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The time when the task first started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1664380800000</para>
        /// </summary>
        [NameInMap("FirstDateStr")]
        [Validation(Required=false)]
        public long? FirstDateStr { get; set; }

        /// <summary>
        /// <para>The interval at which the task is run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
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
        /// <para>The unit of the scan interval. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b></description></item>
        /// <item><description><b>hour</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The end time of the task. The time must be a time frame.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TargetEndTime")]
        [Validation(Required=false)]
        public int? TargetEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the task. The start time must be a time frame.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TargetStartTime")]
        [Validation(Required=false)]
        public int? TargetStartTime { get; set; }

        /// <summary>
        /// <para>The name of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: virus detection task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan task</description></item>
        /// <item><description><b>EMG_VUL_SCHEDULE_SCAN</b>: urgent vulnerability scan task</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>VIRUS_VUL_SCHEDULE_SCAN</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>virus detection task</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>IMAGE_SCAN</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>image scan task</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>EMG_VUL_SCHEDULE_SCAN</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>urgent vulnerability scan task</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EMG_VUL_SCHEDULE_SCAN</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: virus detection task</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan task</description></item>
        /// <item><description><b>EMG_VUL_SCHEDULE_SCAN</b>: urgent vulnerability scan task</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>VIRUS_VUL_SCHEDULE_SCAN</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>virus detection task</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>IMAGE_SCAN</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>image scan task</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>EMG_VUL_SCHEDULE_SCAN</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>urgent vulnerability scan task</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VIRUS_VUL_SCHEDULE_SCAN</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}

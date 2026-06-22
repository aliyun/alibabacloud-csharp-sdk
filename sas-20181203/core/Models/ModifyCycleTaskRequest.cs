// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCycleTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCycleTaskList~~">DescribeCycleTaskList</a> operation to obtain this parameter.</para>
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
        /// <item><description><b>1</b>: enabled.</description></item>
        /// <item><description><b>0</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The first execution time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1664380800000</para>
        /// </summary>
        [NameInMap("FirstDateStr")]
        [Validation(Required=false)]
        public long? FirstDateStr { get; set; }

        /// <summary>
        /// <para>The interval period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        /// <summary>
        /// <para>The extended information field.</para>
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
        /// <para>The unit of the scan cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: day.</description></item>
        /// <item><description><b>hour</b>: hour.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The task end time, in hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TargetEndTime")]
        [Validation(Required=false)]
        public int? TargetEndTime { get; set; }

        /// <summary>
        /// <para>The task start time, in hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TargetStartTime")]
        [Validation(Required=false)]
        public int? TargetStartTime { get; set; }

        /// <summary>
        /// <para>The node name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VIRUS_VUL_SCHEDULE_SCAN</b>: virus scan.</description></item>
        /// <item><description><b>IMAGE_SCAN</b>: image scan.</description></item>
        /// <item><description><b>EMG_VUL_SCHEDULE_SCAN</b>: emergency vulnerability scanning.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EMG_VUL_SCHEDULE_SCAN</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>VIRUS_VUL_SCHEDULE_SCAN</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}

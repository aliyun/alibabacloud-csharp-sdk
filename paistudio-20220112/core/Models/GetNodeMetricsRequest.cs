// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetNodeMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T10:17:06</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The GPU type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>V100</description></item>
        /// <item><description>A100</description></item>
        /// <item><description>A10</description></item>
        /// <item><description>T4</description></item>
        /// <item><description>P100</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>V100</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-08T02:23:30.292Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time step. Default value: 5m. The supported time units are:</para>
        /// <list type="bullet">
        /// <item><description><para>h: hours.</para>
        /// </description></item>
        /// <item><description><para>m: minutes.</para>
        /// </description></item>
        /// <item><description><para>s: seconds.</para>
        /// </description></item>
        /// </list>
        /// <para>If the value does not contain a unit, the default unit is s (seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1h</para>
        /// </summary>
        [NameInMap("TimeStep")]
        [Validation(Required=false)]
        public string TimeStep { get; set; }

        /// <summary>
        /// <para>Specifies whether to display non-essential information. Non-essential information currently includes Labels.
        /// Valid values:</para>
        /// <para>false: does not display non-essential information (default value)
        /// true: displays non-essential information</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}

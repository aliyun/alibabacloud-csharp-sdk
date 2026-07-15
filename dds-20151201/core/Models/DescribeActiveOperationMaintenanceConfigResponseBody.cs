// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationMaintenanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeActiveOperationMaintenanceConfigResponseBodyConfig Config { get; set; }
        public class DescribeActiveOperationMaintenanceConfigResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The time when the O\&amp;M task configuration was created. The time is in the <em>yyyy-mm-dd</em>T<em>hh:mm:ss</em>Z format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The days of the cycle.</para>
            /// <list type="bullet">
            /// <item><description><para>If CycleType is set to Month, this parameter returns the days of the month. Valid values: 1 to 28. Multiple values are separated by commas (,).</para>
            /// </description></item>
            /// <item><description><para>If CycleType is set to Week, this parameter returns the days of the week. Valid values: 1 to 7. Multiple values are separated by commas (,).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The cycle type.</para>
            /// <list type="bullet">
            /// <item><description><para>Month</para>
            /// </description></item>
            /// <item><description><para>Week</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the O\&amp;M time window. The time is in the <em>hh:mm:ss</em>Z format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the O\&amp;M time window. The time is in the <em>hh:mm:ss</em>Z format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The time when the operations and maintenance (O\&amp;M) task configuration was modified. The time is in the <em>yyyy-mm-dd</em>T<em>hh:mm:ss</em>Z format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para>1: Enabled</para>
            /// </description></item>
            /// <item><description><para>2: Disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether a configuration is set.</para>
        /// <list type="bullet">
        /// <item><description><para>1: A configuration is set.</para>
        /// </description></item>
        /// <item><description><para>0: No configuration is set.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasConfig")]
        [Validation(Required=false)]
        public int? HasConfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72651AF9-7897-41A7-8B67-6C15C7F26A0A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

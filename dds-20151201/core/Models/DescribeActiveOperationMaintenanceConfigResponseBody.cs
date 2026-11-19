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
            /// <para>The time when the O&amp;M task configuration was created. The time is in the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cycle time.</para>
            /// <list type="bullet">
            /// <item><description>If CycleType is set to Month, the return value is a number from 1 to 28, which indicates the day of the month. Multiple values are separated by commas (,).</description></item>
            /// <item><description>If CycleType is set to Week, the return value is a number from 1 to 7, which indicates the day of the week. Multiple values are separated by commas (,).</description></item>
            /// </list>
            /// <para>Value format: This field returns a list of numeric serial numbers separated by commas (,), such as &quot;1,2,3&quot;, which indicates the execution days of the O&amp;M cycle. It is not a datetime value and does not involve time formats or time zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The cycle type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Month: Monthly.</description></item>
            /// <item><description>Week: Weekly.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the O&amp;M time window. The time is in the <i>hh:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the O&amp;M time window. The time is in the <i>hh:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M task configuration was modified. The time is in the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is effective. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Effective.</description></item>
            /// <item><description>2: Invalid.</description></item>
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
        /// <para>Indicates whether the O&amp;M task is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Configured.</description></item>
        /// <item><description>0: Not configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasConfig")]
        [Validation(Required=false)]
        public int? HasConfig { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72651AF9-7897-41A7-8B67-6C15C7F26A0A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

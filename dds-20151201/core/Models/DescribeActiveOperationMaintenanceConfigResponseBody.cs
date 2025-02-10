// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationMaintenanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeActiveOperationMaintenanceConfigResponseBodyConfig Config { get; set; }
        public class DescribeActiveOperationMaintenanceConfigResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The time when the O\&amp;M task was created. The timefollows the <em>yyyy-mm-dd</em>t<em>hh:mm:ss</em>z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-20T00:05:54+08:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The start time of the O\&amp;M period. The time follows the <em>hh:mm</em> z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The cyclical type of the O\&amp;M task.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window. The time follows the <em>hh:mm</em>z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window. The time follows the <em>hh:mm</em>z format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was modified. The time follows the <em>yyyy-mm-dd</em>t<em>hh:mm:ss</em>z format. The time is displayed in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-26T05:50:34.000+00:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The state of the O\&amp;M task. Valid values: <b>0</b>: The O\&amp;M task is in the starting state. <b>1</b>: The O\&amp;M task is in the running state. <b>2</b>: The O\&amp;M task is in the stopped state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the O\&amp;M task is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: The O\&amp;M task is configured.</description></item>
        /// <item><description>0: The O\&amp;M task is not configured.</description></item>
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

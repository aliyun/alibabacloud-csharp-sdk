// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeActiveOperationMaintainConfResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried configuration information.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeActiveOperationMaintainConfResponseBodyConfig Config { get; set; }
        public class DescribeActiveOperationMaintainConfResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The time when the O\&amp;M task was created. The time follows the ISO 8601 standard in the <em>yyyy-mm-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-08T02:23:13Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The days on which the O\&amp;M task is executed every week.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The unit of the O\&amp;M task cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Month</description></item>
            /// <item><description>Week</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-12T12:34:40Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: yes.</description></item>
            /// <item><description>2: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the O\&amp;M task is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: yes.</description></item>
        /// <item><description>0: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasConfig")]
        [Validation(Required=false)]
        public int? HasConfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92B3D2F0-B5E3-5592-9A6F-D0A6C34ACBA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

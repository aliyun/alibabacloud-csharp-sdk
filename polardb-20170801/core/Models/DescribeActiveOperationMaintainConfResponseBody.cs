// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeActiveOperationMaintainConfResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeActiveOperationMaintainConfResponseBodyConfig Config { get; set; }
        public class DescribeActiveOperationMaintainConfResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T19:28:46</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The day of the cycle.</para>
            /// <list type="bullet">
            /// <item><description><para>If CycleType is set to Month, this parameter returns a number from 1 to 28 that indicates the day of the month. Multiple days are separated by commas (,).</para>
            /// </description></item>
            /// <item><description><para>If CycleType is set to Week, this parameter returns a number from 1 to 7 that indicates the day of the week. Multiple days are separated by commas (,).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The cycle type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Month: monthly</para>
            /// </description></item>
            /// <item><description><para>Week: weekly</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Week</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public int? CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The time when the configuration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-02T02:10:08Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is enabled. Valid values:1: Enabled2: Disabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether a configuration has been set. Valid values:1: Yes0: NoThe value of this parameter is 0 for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HasConfig")]
        [Validation(Required=false)]
        public long? HasConfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14109129-EF13-5C83-AD86-7581D9552603</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

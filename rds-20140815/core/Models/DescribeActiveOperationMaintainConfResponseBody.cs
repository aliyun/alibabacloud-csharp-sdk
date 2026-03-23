// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeActiveOperationMaintainConfResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration Information</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeActiveOperationMaintainConfResponseBodyConfig Config { get; set; }
        public class DescribeActiveOperationMaintainConfResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>Creation Time, formatted as YYYY-MM-DDTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>Cycle time, with multiple values concatenated by English commas  </para>
            /// <list type="bullet">
            /// <item><description>When cycleType is Week, values 1–7 represent Monday–Sunday  </description></item>
            /// <item><description>When cycleType is Month, values 1–28 are allowed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>Cycle type, either Month or Week</para>
            /// 
            /// <b>Example:</b>
            /// <para>Week</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>End time of the O&amp;M time window, in UTC<br>Default: 20:00:00Z</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>Start time of the O&amp;M time window, in UTC<br>Default: 18:00:00Z</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>Updated At, formatted as YYYY-MM-DDTHH:mm:ssZ, for example, 2018-05-30T14:30:00Z</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Whether it is effective  </para>
            /// <list type="bullet">
            /// <item><description>1: Valid  </description></item>
            /// <item><description>2: Invalid</description></item>
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
        /// <para>Whether a configuration has been set; for the first access, hasConfig is 0  </para>
        /// <list type="bullet">
        /// <item><description>1: Yes  </description></item>
        /// <item><description>0: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasConfig")]
        [Validation(Required=false)]
        public int? HasConfig { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4438AC3E-ABE3-5943-9436-***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

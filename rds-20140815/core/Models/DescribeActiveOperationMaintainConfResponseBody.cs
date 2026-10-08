// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
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
            /// <para>The creation time in the format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cycle time. Multiple values are separated by commas (,).</para>
            /// <list type="bullet">
            /// <item><description>If cycleType is set to Week, valid values are 1 to 7, which represent Monday to Sunday.</description></item>
            /// <item><description>If cycleType is set to Month, valid values are 1 to 28.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The cycle type. Valid values: Month and Week.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Week</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the O&amp;M time window in UTC.
            /// Default value: 20:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the O&amp;M time window in UTC.
            /// Default value: 18:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The modification time in the format of YYYY-MM-DDTHH:mm:ssZ, such as 2018-05-30T14:30:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is effective. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>1: Valid. </description></item>
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
        /// <para>Indicates whether the configuration has been set. The value is 0 for the first access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Yes. </description></item>
        /// <item><description>0: No.</description></item>
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
        /// <para>4438AC3E-ABE3-5943-9436-***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

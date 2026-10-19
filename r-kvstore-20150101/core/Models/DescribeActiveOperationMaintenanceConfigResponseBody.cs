// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationMaintenanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration details of the O&amp;M task.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeActiveOperationMaintenanceConfigResponseBodyConfig Config { get; set; }
        public class DescribeActiveOperationMaintenanceConfigResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The time when the O&amp;M task configuration was created. The time is in the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format (UTC).</para>
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
            /// <item><description>If CycleType is set to Month, a number from 1 to 28 is returned, indicating the day of the month. Multiple values are separated by commas (,). The value is 0 if the configuration is inactive.</description></item>
            /// <item><description>If CycleType is set to Week, a number from 1 to 7 is returned, indicating the day of the week. Multiple values are separated by commas (,). The value is 0 if the configuration is inactive.</description></item>
            /// </list>
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
            /// <item><description>Month: monthly</description></item>
            /// <item><description>Week: weekly</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Week</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the O&amp;M time window. The time is in the <i>hh:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>20:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the O&amp;M time window. The time is in the <i>hh:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The time when the O&amp;M task configuration was last modified. The time is in the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30T14:30:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration is active. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Active.</description></item>
            /// <item><description>2: Inactive.</description></item>
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
        /// <para>Indicates whether the configuration exists. Valid values:</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>794120D1-E0CF-4713-BAE4-EBAEA04506AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

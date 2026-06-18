// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-11T10:08:27Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The cycle time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3,4,5,6,7</para>
            /// </summary>
            [NameInMap("CycleTime")]
            [Validation(Required=false)]
            public string CycleTime { get; set; }

            /// <summary>
            /// <para>The cycle type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Week</para>
            /// </summary>
            [NameInMap("CycleType")]
            [Validation(Required=false)]
            public string CycleType { get; set; }

            /// <summary>
            /// <para>The end time of the O&amp;M window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the O&amp;M window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04:00:00Z</para>
            /// </summary>
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-11T10:08:27Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the O&amp;M window has been configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: configured.</description></item>
        /// <item><description>0: not configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasConfig")]
        [Validation(Required=false)]
        public long? HasConfig { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A586DCB-39A6-4050-81CC-C7BD4CCDB49F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

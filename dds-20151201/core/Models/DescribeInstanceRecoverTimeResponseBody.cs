// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeInstanceRecoverTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8CA8312-530A-413A-9129-F2BB32A8D404</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time ranges to which data can be restored. The time ranges include those used for point-in-time data restoration.</para>
        /// </summary>
        [NameInMap("RestoreRanges")]
        [Validation(Required=false)]
        public List<DescribeInstanceRecoverTimeResponseBodyRestoreRanges> RestoreRanges { get; set; }
        public class DescribeInstanceRecoverTimeResponseBodyRestoreRanges : TeaModel {
            /// <summary>
            /// <para>The beginning of the time range to which data can be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:33:20Z</para>
            /// </summary>
            [NameInMap("RestoreBeginTime")]
            [Validation(Required=false)]
            public string RestoreBeginTime { get; set; }

            /// <summary>
            /// <para>The end of the time range to which data can be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:43:20Z</para>
            /// </summary>
            [NameInMap("RestoreEndTime")]
            [Validation(Required=false)]
            public string RestoreEndTime { get; set; }

            /// <summary>
            /// <para>The method used to restore data. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>PointInTime (default): Data is restored to a point in time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PointInTime</para>
            /// </summary>
            [NameInMap("RestoreType")]
            [Validation(Required=false)]
            public string RestoreType { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeClusterRecoverTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60EEBD77-227C-5B39-86EA-D89163C5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of cluster backup sets. A cluster backup contains the backup set of each node.</para>
        /// </summary>
        [NameInMap("RestoreRanges")]
        [Validation(Required=false)]
        public List<DescribeClusterRecoverTimeResponseBodyRestoreRanges> RestoreRanges { get; set; }
        public class DescribeClusterRecoverTimeResponseBodyRestoreRanges : TeaModel {
            /// <summary>
            /// <para>The beginning of the restorable time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:33:20Z</para>
            /// </summary>
            [NameInMap("RestoreBeginTime")]
            [Validation(Required=false)]
            public string RestoreBeginTime { get; set; }

            /// <summary>
            /// <para>The end of the restorable time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:43:20Z</para>
            /// </summary>
            [NameInMap("RestoreEndTime")]
            [Validation(Required=false)]
            public string RestoreEndTime { get; set; }

            /// <summary>
            /// <para>The restoration method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PointInTime</b> (default): point-in-time restoration.</description></item>
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

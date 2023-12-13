// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeClusterRecoverTimeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The cluster backup sets of the instance. A cluster backup file contains the backup sets of each node.
        /// </summary>
        [NameInMap("RestoreRanges")]
        [Validation(Required=false)]
        public List<DescribeClusterRecoverTimeResponseBodyRestoreRanges> RestoreRanges { get; set; }
        public class DescribeClusterRecoverTimeResponseBodyRestoreRanges : TeaModel {
            /// <summary>
            /// The beginning of the time range to which data can be restored.
            /// </summary>
            [NameInMap("RestoreBeginTime")]
            [Validation(Required=false)]
            public string RestoreBeginTime { get; set; }

            /// <summary>
            /// The end of the time range to which data can be restored.
            /// </summary>
            [NameInMap("RestoreEndTime")]
            [Validation(Required=false)]
            public string RestoreEndTime { get; set; }

            /// <summary>
            /// The method used to restore data. Valid values:
            /// 
            /// *   \*\* PointInTime\*\* (default): Data is restored based on point in time
            /// </summary>
            [NameInMap("RestoreType")]
            [Validation(Required=false)]
            public string RestoreType { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeInstanceRecoverTimeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time ranges to which data can be restored. The time ranges include those used for point-in-time data restoration.
        /// </summary>
        [NameInMap("RestoreRanges")]
        [Validation(Required=false)]
        public List<DescribeInstanceRecoverTimeResponseBodyRestoreRanges> RestoreRanges { get; set; }
        public class DescribeInstanceRecoverTimeResponseBodyRestoreRanges : TeaModel {
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
            /// The method used to restore data. Valid value:
            /// 
            /// *   PointInTime (default): Data is restored to a point in time.
            /// </summary>
            [NameInMap("RestoreType")]
            [Validation(Required=false)]
            public string RestoreType { get; set; }

        }

    }

}

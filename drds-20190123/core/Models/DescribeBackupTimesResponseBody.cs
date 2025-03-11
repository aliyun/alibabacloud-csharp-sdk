// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupTimesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4780A19F-5ECB-4C56-AD20-966A3FF9DE5R</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates the information about the time range within which the data of the instance can be restored to a point in time.</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public DescribeBackupTimesResponseBodyRestoreTime RestoreTime { get; set; }
        public class DescribeBackupTimesResponseBodyRestoreTime : TeaModel {
            /// <summary>
            /// <para>Indicates the end time. The time is in the UNIX timestamp format. The time is in UTC. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1568636922671</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Indicates the start time. The time is in the UNIX timestamp format. The time must be in UTC. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1568632853000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

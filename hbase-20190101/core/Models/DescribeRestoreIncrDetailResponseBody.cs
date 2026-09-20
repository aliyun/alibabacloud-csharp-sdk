// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreIncrDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0FE2717-E194-465A-B27B-7373F96E580B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The incremental restoration details.</para>
        /// </summary>
        [NameInMap("RestoreIncrDetail")]
        [Validation(Required=false)]
        public DescribeRestoreIncrDetailResponseBodyRestoreIncrDetail RestoreIncrDetail { get; set; }
        public class DescribeRestoreIncrDetailResponseBodyRestoreIncrDetail : TeaModel {
            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:44Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0/0</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <para>The synchronization latency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 ms</para>
            /// </summary>
            [NameInMap("RestoreDelay")]
            [Validation(Required=false)]
            public string RestoreDelay { get; set; }

            /// <summary>
            /// <para>The synchronization start point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-02T18:00:00Z</para>
            /// </summary>
            [NameInMap("RestoreStartTs")]
            [Validation(Required=false)]
            public string RestoreStartTs { get; set; }

            /// <summary>
            /// <para>The synchronization point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot;\&quot;</para>
            /// </summary>
            [NameInMap("RestoredTs")]
            [Validation(Required=false)]
            public string RestoredTs { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-05T06:45:44Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}

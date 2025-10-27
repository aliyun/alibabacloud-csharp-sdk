// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeMapRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_exec_name</para>
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        [NameInMap("ItemCounts")]
        [Validation(Required=false)]
        public DescribeMapRunResponseBodyItemCounts ItemCounts { get; set; }
        public class DescribeMapRunResponseBodyItemCounts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Aborted")]
            [Validation(Required=false)]
            public long? Aborted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Pending")]
            [Validation(Required=false)]
            public long? Pending { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Running")]
            [Validation(Required=false)]
            public long? Running { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public long? Succeed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c39142f1345b196d678333c41f113000</para>
        /// </summary>
        [NameInMap("MapRunName")]
        [Validation(Required=false)]
        public string MapRunName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3A44E113-9962-5B0B-AB92-14060EFE3164</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-10-24T14:11:26+08:00</para>
        /// </summary>
        [NameInMap("StartedTime")]
        [Validation(Required=false)]
        public string StartedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-10-24T14:11:28+08:00</para>
        /// </summary>
        [NameInMap("StoppedTime")]
        [Validation(Required=false)]
        public string StoppedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ToleratedFailedCount")]
        [Validation(Required=false)]
        public long? ToleratedFailedCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ToleratedFailedPercentage")]
        [Validation(Required=false)]
        public float? ToleratedFailedPercentage { get; set; }

    }

}

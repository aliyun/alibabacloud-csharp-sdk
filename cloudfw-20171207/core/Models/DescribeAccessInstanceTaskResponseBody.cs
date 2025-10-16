// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17151381075</para>
        /// </summary>
        [NameInMap("TaskFinishTimestamp")]
        [Validation(Required=false)]
        public long? TaskFinishTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3c9d576f-fce0-4caa-9116-15033509bdb6</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17151361285</para>
        /// </summary>
        [NameInMap("TaskStartTimestamp")]
        [Validation(Required=false)]
        public long? TaskStartTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskSteps")]
        [Validation(Required=false)]
        public List<DescribeAccessInstanceTaskResponseBodyTaskSteps> TaskSteps { get; set; }
        public class DescribeAccessInstanceTaskResponseBodyTaskSteps : TeaModel {
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("StepProgress")]
            [Validation(Required=false)]
            public string StepProgress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

    }

}

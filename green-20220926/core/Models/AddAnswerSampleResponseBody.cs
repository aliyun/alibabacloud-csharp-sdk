// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddAnswerSampleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>alxxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddAnswerSampleResponseBodyResult Result { get; set; }
        public class AddAnswerSampleResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("I18nKey")]
            [Validation(Required=false)]
            public string I18nKey { get; set; }

            [NameInMap("IllegalLengthSamples")]
            [Validation(Required=false)]
            public List<string> IllegalLengthSamples { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>118</para>
            /// </summary>
            [NameInMap("InvalidCount")]
            [Validation(Required=false)]
            public int? InvalidCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alxxxx</para>
            /// </summary>
            [NameInMap("LibId")]
            [Validation(Required=false)]
            public string LibId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("RepeatCount")]
            [Validation(Required=false)]
            public int? RepeatCount { get; set; }

            [NameInMap("RepeatSamples")]
            [Validation(Required=false)]
            public List<string> RepeatSamples { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>318</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alAxbbxxxx-xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>534</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alAxbbxxxx-xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

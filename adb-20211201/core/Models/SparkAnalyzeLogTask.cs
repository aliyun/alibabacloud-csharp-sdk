// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkAnalyzeLogTask : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-adbxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public LogAnalyzeResult Result { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RuleMatched")]
        [Validation(Required=false)]
        public bool? RuleMatched { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672123543000</para>
        /// </summary>
        [NameInMap("StartedTimeInMillis")]
        [Validation(Required=false)]
        public long? StartedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672123543000</para>
        /// </summary>
        [NameInMap("SubmittedTimeInMillis")]
        [Validation(Required=false)]
        public long? SubmittedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Driver log not found</para>
        /// </summary>
        [NameInMap("TaskErrMsg")]
        [Validation(Required=false)]
        public string TaskErrMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WAITING</para>
        /// </summary>
        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1672123543000</para>
        /// </summary>
        [NameInMap("TerminatedTimeInMillis")]
        [Validation(Required=false)]
        public long? TerminatedTimeInMillis { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13719918xxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SparkAnalyzeLogTask : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-adbxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The analysis result of the task.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public LogAnalyzeResult Result { get; set; }

        /// <summary>
        /// <para>Indicates whether the task matched a rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RuleMatched")]
        [Validation(Required=false)]
        public bool? RuleMatched { get; set; }

        /// <summary>
        /// <para>The time when the task was started. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672123543000</para>
        /// </summary>
        [NameInMap("StartedTimeInMillis")]
        [Validation(Required=false)]
        public long? StartedTimeInMillis { get; set; }

        /// <summary>
        /// <para>The time when the task was submitted. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672123543000</para>
        /// </summary>
        [NameInMap("SubmittedTimeInMillis")]
        [Validation(Required=false)]
        public long? SubmittedTimeInMillis { get; set; }

        /// <summary>
        /// <para>The error message returned if the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Driver log not found</para>
        /// </summary>
        [NameInMap("TaskErrMsg")]
        [Validation(Required=false)]
        public string TaskErrMsg { get; set; }

        /// <summary>
        /// <para>The ID of the Spark log analysis task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The state of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAITING</para>
        /// </summary>
        [NameInMap("TaskState")]
        [Validation(Required=false)]
        public string TaskState { get; set; }

        /// <summary>
        /// <para>The time when the task was terminated. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672123543000</para>
        /// </summary>
        [NameInMap("TerminatedTimeInMillis")]
        [Validation(Required=false)]
        public long? TerminatedTimeInMillis { get; set; }

        /// <summary>
        /// <para>The ID of the user who submitted the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13719918xxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}

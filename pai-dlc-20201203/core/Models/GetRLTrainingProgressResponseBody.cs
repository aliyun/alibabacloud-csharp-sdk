// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLTrainingProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The readiness of the data buffer. The ETA is estimated by using the rollout completion rate as a proxy.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Buffer")]
        [Validation(Required=false)]
        public RLProgressBuffer Buffer { get; set; }

        /// <summary>
        /// <para>The parsing result of the training configuration dump. Unparsed fields are empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public RLProgressConfig Config { get; set; }

        /// <summary>
        /// <para>The readiness of the eval buffer (tag=-1).</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Eval")]
        [Validation(Required=false)]
        public RLProgressEval Eval { get; set; }

        /// <summary>
        /// <para>The fatal errors. A maximum of 5 errors are included, and sandbox business noise is excluded.</para>
        /// </summary>
        [NameInMap("Fatal")]
        [Validation(Required=false)]
        public List<RLProgressFatal> Fatal { get; set; }

        /// <summary>
        /// <para>Indicates whether master-0 has logs within the window. If the value is false, other fields use default values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Found")]
        [Validation(Required=false)]
        public bool? Found { get; set; }

        /// <summary>
        /// <para>Indicates whether no fatal errors are found. The value is true if Fatal is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HealthOk")]
        [Validation(Required=false)]
        public bool? HealthOk { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-xxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The time of the last log in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("LastLogTime")]
        [Validation(Required=false)]
        public long? LastLogTime { get; set; }

        /// <summary>
        /// <para>The original text of the latest trainer phase marker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disagg: actor generate sequences</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The time of the phase marker in UNIX seconds, used by the frontend to calculate the dwell time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("PhaseTime")]
        [Validation(Required=false)]
        public long? PhaseTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rollout throughput.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Rollout")]
        [Validation(Required=false)]
        public RLProgressRollout Rollout { get; set; }

        /// <summary>
        /// <para>The current server time in UNIX seconds, used by the frontend to calculate the time since the last log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787475398</para>
        /// </summary>
        [NameInMap("ServerNow")]
        [Validation(Required=false)]
        public long? ServerNow { get; set; }

        /// <summary>
        /// <para>The soft alerts for slow inference. A maximum of 20 details are included.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Slow")]
        [Validation(Required=false)]
        public RLProgressSlow Slow { get; set; }

        /// <summary>
        /// <para>The phase pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Index&quot;: &quot;Group0-Stage0&quot;, &quot;StageInfo&quot;: {&quot;Status&quot;: &quot;FAIL&quot;, &quot;EndTime&quot;: 0, &quot;Jobs&quot;: [{&quot;Id&quot;: 477917255}], &quot;Name&quot;: u&quot;\u9636\u6bb51&quot;, &quot;StartTime&quot;: 1784858533000}, &quot;Name&quot;: u&quot;\u9636\u6bb51&quot;}]</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Stages")]
        [Validation(Required=false)]
        public RLProgressStages Stages { get; set; }

        /// <summary>
        /// <para>The step progress. Pace is calculated based on the difference between two adjacent Step markers. ETA = (Total - Current) × Pace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public RLProgressStep Step { get; set; }

        /// <summary>
        /// <para>The latest generation throughput in tokens per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200</para>
        /// </summary>
        [NameInMap("Throughput")]
        [Validation(Required=false)]
        public double? Throughput { get; set; }

        /// <summary>
        /// <para>The training mode. Valid values: disagg (decoupled training and inference), colocate (integrated training and inference), or an empty string (unrecognized).</para>
        /// 
        /// <b>Example:</b>
        /// <para>disagg</para>
        /// </summary>
        [NameInMap("TrainMode")]
        [Validation(Required=false)]
        public string TrainMode { get; set; }

        /// <summary>
        /// <para>The internal status of the trainer, such as mini-batch, micro-batch, or parameter synchronization.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Trainer")]
        [Validation(Required=false)]
        public RLProgressTrainer Trainer { get; set; }

    }

}

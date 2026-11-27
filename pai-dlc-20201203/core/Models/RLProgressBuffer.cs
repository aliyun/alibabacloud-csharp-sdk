// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressBuffer : TeaModel {
        /// <summary>
        /// <para>The total number of consumed samples in unfinished buffers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Consumed")]
        [Validation(Required=false)]
        public int? Consumed { get; set; }

        /// <summary>
        /// <para>The buffer details split by tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Tag&quot;:1,&quot;Ready&quot;:500,&quot;Consumed&quot;:0,&quot;Finished&quot;:500,&quot;Total&quot;:512}]</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public List<RLProgressBufferDetail> Detail { get; set; }

        /// <summary>
        /// <para>The estimated number of seconds remaining to fill the buffer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EtaSec")]
        [Validation(Required=false)]
        public long? EtaSec { get; set; }

        /// <summary>
        /// <para>The fill rate in entries per minute, estimated by using the rollout completion rate as a proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.5</para>
        /// </summary>
        [NameInMap("FillRatePerMin")]
        [Validation(Required=false)]
        public double? FillRatePerMin { get; set; }

        /// <summary>
        /// <para>The total number of finished samples in unfinished buffers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public int? Finished { get; set; }

        /// <summary>
        /// <para>The completion percentage of the finished count relative to the target count, up to 100%. This value is provided when the target count is greater than 0. This value is not equivalent to the proportion of currently available samples indicated by the ready count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Pct")]
        [Validation(Required=false)]
        public double? Pct { get; set; }

        /// <summary>
        /// <para>The total number of ready samples in unfinished buffers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Ready")]
        [Validation(Required=false)]
        public int? Ready { get; set; }

        /// <summary>
        /// <para>The total number of target samples in unfinished buffers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public int? Target { get; set; }

        /// <summary>
        /// <para>The configured training batch size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("TrainBatchSize")]
        [Validation(Required=false)]
        public int? TrainBatchSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the consumed count is greater than 0, which means that batches have been fetched and the trainer is updating.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Training")]
        [Validation(Required=false)]
        public bool? Training { get; set; }

    }

}

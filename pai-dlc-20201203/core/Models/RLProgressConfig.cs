// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressConfig : TeaModel {
        /// <summary>
        /// <para>The number of mini-batches per step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NumMinibatches")]
        [Validation(Required=false)]
        public int? NumMinibatches { get; set; }

        /// <summary>
        /// <para>The PPO mini-batch size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("PpoMiniBatchSize")]
        [Validation(Required=false)]
        public int? PpoMiniBatchSize { get; set; }

        /// <summary>
        /// <para>The number of rollouts per prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RolloutN")]
        [Validation(Required=false)]
        public int? RolloutN { get; set; }

        /// <summary>
        /// <para>The total number of training steps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalSteps")]
        [Validation(Required=false)]
        public int? TotalSteps { get; set; }

        /// <summary>
        /// <para>The training batch size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("TrainBatchSize")]
        [Validation(Required=false)]
        public int? TrainBatchSize { get; set; }

    }

}

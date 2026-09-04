// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLSampleEvent : TeaModel {
        /// <summary>
        /// <para>The details. For Megatron rows, the value is rank=..,global_step=..,ppo_epoch=..</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid_generated</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The event source component. For Megatron rows, the value is &quot;{phase} {status}&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataLoader</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The training step to which the event belongs (raw string). For Megatron rows, this is empty because the step is included in Detail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("GlobalStep")]
        [Validation(Required=false)]
        public string GlobalStep { get; set; }

        /// <summary>
        /// <para>The stage. For Megatron rows, this is normalized to TRAIN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_PREPROCESS</para>
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// <para>The millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787293208012</para>
        /// </summary>
        [NameInMap("TimestampMs")]
        [Validation(Required=false)]
        public long? TimestampMs { get; set; }

        /// <summary>
        /// <para>The event target component. For Megatron rows, the value is the function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PPOTrainerV1</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}

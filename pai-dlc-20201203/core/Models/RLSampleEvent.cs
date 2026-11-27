// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLSampleEvent : TeaModel {
        /// <summary>
        /// <para>The supplementary information for the event. The specific content depends on the event type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid_generated</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The source component or execution stage of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataLoader</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The decimal string of the training step. An empty string is used when the corresponding information is not collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("GlobalStep")]
        [Validation(Required=false)]
        public string GlobalStep { get; set; }

        /// <summary>
        /// <para>The training or sampling stage to which the event belongs.</para>
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
        /// <para>The destination component or execution action of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trainer</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class EndDialogueRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fb819b5-d032-48a9-ae5e-cff041b83596</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;duration\&quot;:40,\&quot;endTime\&quot;:1645082505345,\&quot;hangUpDirection\&quot;:\&quot;ivr\&quot;,\&quot;hasLastPlaybackCompleted\&quot;:true,\&quot;startTime\&quot;:1645082505305}</para>
        /// </summary>
        [NameInMap("HangUpParams")]
        [Validation(Required=false)]
        public string HangUpParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e48e45dd-e47a-4744-a063-f08cbebb1c5a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1399572315967217</para>
        /// </summary>
        [NameInMap("InstanceOwnerId")]
        [Validation(Required=false)]
        public long? InstanceOwnerId { get; set; }

    }

}

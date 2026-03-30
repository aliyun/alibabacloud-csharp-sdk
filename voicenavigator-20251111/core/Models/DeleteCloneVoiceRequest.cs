// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class DeleteCloneVoiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>e48e45dd-e47a-4744-a063-f08cbebb1c5b</para>
        /// </summary>
        [NameInMap("CloneVoiceId")]
        [Validation(Required=false)]
        public string CloneVoiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e48e45dd-e47a-4744-a063-f08cbebb1c5a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

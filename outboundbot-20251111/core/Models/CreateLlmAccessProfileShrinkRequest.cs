// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateLlmAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33014787-cc13-49d3-ab2f-a98aa8f15fbb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language model access configuration.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string ProfileShrink { get; set; }

    }

}

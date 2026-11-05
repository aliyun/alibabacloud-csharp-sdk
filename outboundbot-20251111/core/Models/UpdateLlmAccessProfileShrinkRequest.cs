// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateLlmAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access profile ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ed06946e-dcbb-4f3a-baf8-a5feae0198e9</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4eee9bf8-1319-468f-ac82-83c50ae389f8</para>
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

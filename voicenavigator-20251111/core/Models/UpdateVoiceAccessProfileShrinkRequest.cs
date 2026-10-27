// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class UpdateVoiceAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access profile ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The voice engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VOLC</para>
        /// </summary>
        [NameInMap("NlsEngine")]
        [Validation(Required=false)]
        public string NlsEngine { get; set; }

        /// <summary>
        /// <para>The parameter configuration for the selected voice engine.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string ProfileShrink { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateVoiceAccessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The voice service provider.
        /// BAILIAN: Bailian.
        /// VOLC: Doubao.
        /// IFLYTEK: iFLYTEK.
        /// TENCENT: Tencent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BAILIAN</para>
        /// </summary>
        [NameInMap("NlsEngine")]
        [Validation(Required=false)]
        public string NlsEngine { get; set; }

        /// <summary>
        /// <para>The provider configuration information.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string ProfileShrink { get; set; }

    }

}

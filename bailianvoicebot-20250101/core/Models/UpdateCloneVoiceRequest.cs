// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class UpdateCloneVoiceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bailian business workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-3pptowd2olrctsvc</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The ID of the cloned voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8ee1160a-6999-478f-8df6-f33ef21f27d5</para>
        /// </summary>
        [NameInMap("CloneVoiceId")]
        [Validation(Required=false)]
        public string CloneVoiceId { get; set; }

        /// <summary>
        /// <para>The name of the cloned voice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestClonedVoice</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}

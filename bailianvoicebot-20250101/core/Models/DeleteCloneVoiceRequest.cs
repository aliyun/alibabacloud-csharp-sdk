// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class DeleteCloneVoiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-zzu528i29ecnprcl</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8ee1160a-6999-478f-8df6-f33ef21f27d5</para>
        /// </summary>
        [NameInMap("CloneVoiceId")]
        [Validation(Required=false)]
        public string CloneVoiceId { get; set; }

    }

}

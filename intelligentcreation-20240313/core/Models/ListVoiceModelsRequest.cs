// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListVoiceModelsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>offlineSynthesis</para>
        /// </summary>
        [NameInMap("useScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE_VOICE</para>
        /// </summary>
        [NameInMap("voiceType")]
        [Validation(Required=false)]
        public string VoiceType { get; set; }

    }

}

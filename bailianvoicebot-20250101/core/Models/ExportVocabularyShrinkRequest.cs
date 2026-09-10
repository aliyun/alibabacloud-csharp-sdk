// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class ExportVocabularyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bailian business workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-c11iig67g863rih8</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The list of hot word IDs.</para>
        /// </summary>
        [NameInMap("VocabularyIds")]
        [Validation(Required=false)]
        public string VocabularyIdsShrink { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ExportVocabularyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Voice Navigator instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the vocabularies to export.</para>
        /// </summary>
        [NameInMap("VocabularyIds")]
        [Validation(Required=false)]
        public string VocabularyIdsShrink { get; set; }

    }

}

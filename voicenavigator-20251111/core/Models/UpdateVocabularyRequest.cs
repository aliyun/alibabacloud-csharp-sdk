// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class UpdateVocabularyRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Contains professional terms for finance scenarios</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The name of the hot word.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Finance scenario hot words</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The hot word ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d74d6290-7cbe-4436-b5d7-014ebb0f4061</para>
        /// </summary>
        [NameInMap("VocabularyId")]
        [Validation(Required=false)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// <para>The list of hot words.</para>
        /// </summary>
        [NameInMap("Words")]
        [Validation(Required=false)]
        public Dictionary<string, string> Words { get; set; }

    }

}

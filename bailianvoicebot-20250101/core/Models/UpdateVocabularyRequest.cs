// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class UpdateVocabularyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Model Studio business unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-c11iig67g863rih8</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The description of the vocabulary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>包含金融场景专业术语</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the vocabulary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>金融场景热词</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the vocabulary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d74d6290-7cbe-4436-b5d7-014ebb0f4061</para>
        /// </summary>
        [NameInMap("VocabularyId")]
        [Validation(Required=false)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// <para>An object containing the words in the vocabulary and their corresponding weights.</para>
        /// </summary>
        [NameInMap("Words")]
        [Validation(Required=false)]
        public Dictionary<string, string> Words { get; set; }

    }

}

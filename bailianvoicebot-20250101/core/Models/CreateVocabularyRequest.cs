// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateVocabularyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bailian business workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-baployoyopf22m2r</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Contains financial industry terminology</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the hot word list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Financial industry hot words</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The hot word list.</para>
        /// </summary>
        [NameInMap("Words")]
        [Validation(Required=false)]
        public Dictionary<string, string> Words { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class WritingOutline : TeaModel {
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<OutlineWritingArticle> Articles { get; set; }

        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<WritingOutline> Children { get; set; }

        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public string OutlineId { get; set; }

        [NameInMap("SearchKeyWordList")]
        [Validation(Required=false)]
        public List<string> SearchKeyWordList { get; set; }

        [NameInMap("WordCount")]
        [Validation(Required=false)]
        public string WordCount { get; set; }

        [NameInMap("WritingTips")]
        [Validation(Required=false)]
        public string WritingTips { get; set; }

    }

}

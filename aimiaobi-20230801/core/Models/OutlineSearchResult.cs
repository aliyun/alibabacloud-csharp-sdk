// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class OutlineSearchResult : TeaModel {
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public List<OutlineWritingArticle> Articles { get; set; }

        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public string OutlineId { get; set; }

        [NameInMap("PrimaryOutline")]
        [Validation(Required=false)]
        public string PrimaryOutline { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}

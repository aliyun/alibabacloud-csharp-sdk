// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class OutlineWritingArticle : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        [NameInMap("PrimaryOutline")]
        [Validation(Required=false)]
        public string PrimaryOutline { get; set; }

        [NameInMap("PubTime")]
        [Validation(Required=false)]
        public string PubTime { get; set; }

        [NameInMap("SearchSource")]
        [Validation(Required=false)]
        public string SearchSource { get; set; }

        [NameInMap("SearchSourceName")]
        [Validation(Required=false)]
        public string SearchSourceName { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}

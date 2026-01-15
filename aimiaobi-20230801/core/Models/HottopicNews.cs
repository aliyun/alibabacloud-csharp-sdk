// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class HottopicNews : TeaModel {
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public List<HottopicNewsComments> Comments { get; set; }
        public class HottopicNewsComments : TeaModel {
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}

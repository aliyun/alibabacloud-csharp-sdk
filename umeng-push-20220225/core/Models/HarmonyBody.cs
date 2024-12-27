// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class HarmonyBody : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("addBadge")]
        [Validation(Required=false)]
        public int? AddBadge { get; set; }

        [NameInMap("afterOpen")]
        [Validation(Required=false)]
        public string AfterOpen { get; set; }

        [NameInMap("bigBody")]
        [Validation(Required=false)]
        public string BigBody { get; set; }

        [NameInMap("custom")]
        [Validation(Required=false)]
        public string Custom { get; set; }

        [NameInMap("img")]
        [Validation(Required=false)]
        public string Img { get; set; }

        [NameInMap("largeIcon")]
        [Validation(Required=false)]
        public string LargeIcon { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class Message2ThirdChannel : TeaModel {
        [NameInMap("SetBadge")]
        [Validation(Required=false)]
        public long? SetBadge { get; set; }

        [NameInMap("addBadge")]
        [Validation(Required=false)]
        public long? AddBadge { get; set; }

        [NameInMap("bigBody")]
        [Validation(Required=false)]
        public string BigBody { get; set; }

        [NameInMap("bigTitle")]
        [Validation(Required=false)]
        public string BigTitle { get; set; }

        [NameInMap("expandImage")]
        [Validation(Required=false)]
        public string ExpandImage { get; set; }

        [NameInMap("img")]
        [Validation(Required=false)]
        public string Img { get; set; }

        [NameInMap("sound")]
        [Validation(Required=false)]
        public string Sound { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

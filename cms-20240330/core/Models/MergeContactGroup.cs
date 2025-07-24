// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeContactGroup : TeaModel {
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<string> Contacts { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extend { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}

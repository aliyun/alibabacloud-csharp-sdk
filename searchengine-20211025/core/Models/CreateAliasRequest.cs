// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateAliasRequest : TeaModel {
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("index")]
        [Validation(Required=false)]
        public string Index { get; set; }

        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

    }

}

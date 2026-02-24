// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IndexKey : TeaModel {
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        [NameInMap("embedding")]
        [Validation(Required=false)]
        public string Embedding { get; set; }

        [NameInMap("jsonKeys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexJsonKey> JsonKeys { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

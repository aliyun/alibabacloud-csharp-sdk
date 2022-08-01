// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class KeysValue : TeaModel {
        [NameInMap("caseSensitive")]
        [Validation(Required=false)]
        public bool? CaseSensitive { get; set; }

        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public List<string> Token { get; set; }

        [NameInMap("doc_value")]
        [Validation(Required=false)]
        public bool? DocValue { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateComponentIndexRequest : TeaModel {
        [NameInMap("_meta")]
        [Validation(Required=false)]
        public Dictionary<string, object> Meta { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public UpdateComponentIndexRequestTemplate Template { get; set; }
        public class UpdateComponentIndexRequestTemplate : TeaModel {
            [NameInMap("aliases")]
            [Validation(Required=false)]
            public Dictionary<string, string> Aliases { get; set; }
            [NameInMap("mappings")]
            [Validation(Required=false)]
            public Dictionary<string, string> Mappings { get; set; }
            [NameInMap("settings")]
            [Validation(Required=false)]
            public Dictionary<string, string> Settings { get; set; }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateComponentIndexRequest : TeaModel {
        [NameInMap("_meta")]
        [Validation(Required=false)]
        public Dictionary<string, object> Meta { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public CreateComponentIndexRequestTemplate Template { get; set; }
        public class CreateComponentIndexRequestTemplate : TeaModel {
            [NameInMap("aliases")]
            [Validation(Required=false)]
            public Dictionary<string, object> Aliases { get; set; }

            [NameInMap("mappings")]
            [Validation(Required=false)]
            public Dictionary<string, object> Mappings { get; set; }

            [NameInMap("settings")]
            [Validation(Required=false)]
            public Dictionary<string, object> Settings { get; set; }

        }

    }

}

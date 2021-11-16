// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListIndexTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListIndexTemplatesResponseBodyResult> Result { get; set; }
        public class ListIndexTemplatesResponseBodyResult : TeaModel {
            [NameInMap("dataStream")]
            [Validation(Required=false)]
            public bool? DataStream { get; set; }

            [NameInMap("ilmPolicy")]
            [Validation(Required=false)]
            public string IlmPolicy { get; set; }

            [NameInMap("indexPatterns")]
            [Validation(Required=false)]
            public List<string> IndexPatterns { get; set; }

            [NameInMap("indexTemplate")]
            [Validation(Required=false)]
            public string IndexTemplate { get; set; }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public ListIndexTemplatesResponseBodyResultTemplate Template { get; set; }
            public class ListIndexTemplatesResponseBodyResultTemplate : TeaModel {
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public string Aliases { get; set; }
                [NameInMap("mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }
            };

        }

    }

}

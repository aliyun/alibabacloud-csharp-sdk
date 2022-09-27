// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDeprecatedTemplatesResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDeprecatedTemplatesResponseBodyHeaders Headers { get; set; }
        public class ListDeprecatedTemplatesResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDeprecatedTemplatesResponseBodyResult> Result { get; set; }
        public class ListDeprecatedTemplatesResponseBodyResult : TeaModel {
            [NameInMap("dataStream")]
            [Validation(Required=false)]
            public bool? DataStream { get; set; }

            [NameInMap("indexPatterns")]
            [Validation(Required=false)]
            public List<string> IndexPatterns { get; set; }

            [NameInMap("indexTemplate")]
            [Validation(Required=false)]
            public string IndexTemplate { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public ListDeprecatedTemplatesResponseBodyResultTemplate Template { get; set; }
            public class ListDeprecatedTemplatesResponseBodyResultTemplate : TeaModel {
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public string Aliases { get; set; }

                [NameInMap("mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }

                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

            }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

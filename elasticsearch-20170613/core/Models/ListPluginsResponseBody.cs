// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPluginsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPluginsResponseBodyHeaders Headers { get; set; }
        public class ListPluginsResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPluginsResponseBodyResult> Result { get; set; }
        public class ListPluginsResponseBodyResult : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

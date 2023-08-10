// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class Summary : TeaModel {
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public SummaryMeta Meta { get; set; }
        public class SummaryMeta : TeaModel {
            [NameInMap("element")]
            [Validation(Required=false)]
            public string Element { get; set; }

            [NameInMap("ellipsis")]
            [Validation(Required=false)]
            public string Ellipsis { get; set; }

            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("len")]
            [Validation(Required=false)]
            public int? Len { get; set; }

            [NameInMap("snippet")]
            [Validation(Required=false)]
            public string Snippet { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Igraph20210621.Models
{
    public class ListGraphSchemasRequest : TeaModel {
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("pageLimit")]
        [Validation(Required=false)]
        public string PageLimit { get; set; }

        [NameInMap("pageStart")]
        [Validation(Required=false)]
        public string PageStart { get; set; }

        [NameInMap("returnSpec")]
        [Validation(Required=false)]
        public string ReturnSpec { get; set; }

        [NameInMap("schemaStatus")]
        [Validation(Required=false)]
        public string SchemaStatus { get; set; }

    }

}

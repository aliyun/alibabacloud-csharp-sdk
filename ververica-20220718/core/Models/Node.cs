// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Node : TeaModel {
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("connector")]
        [Validation(Required=false)]
        public string Connector { get; set; }

        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("isTemporary")]
        [Validation(Required=false)]
        public bool? IsTemporary { get; set; }

        [NameInMap("tables")]
        [Validation(Required=false)]
        public List<LineageTable> Tables { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class SchemaTablesValue : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("primaryTable")]
        [Validation(Required=false)]
        public bool? PrimaryTable { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public Dictionary<string, SchemaTablesValueFieldsValue> Fields { get; set; }

    }

}

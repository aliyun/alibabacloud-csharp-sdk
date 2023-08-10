// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class SchemaTablesValueFieldsValue : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public bool? PrimaryKey { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("joinWith")]
        [Validation(Required=false)]
        public List<string> JoinWith { get; set; }

        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

    }

}

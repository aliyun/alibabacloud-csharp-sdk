// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Table : TeaModel {
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("partitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public Schema Schema { get; set; }

    }

}

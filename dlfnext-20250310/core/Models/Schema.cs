// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Schema : TeaModel {
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DataField> Fields { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        [NameInMap("partitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        [NameInMap("primaryKeys")]
        [Validation(Required=false)]
        public List<string> PrimaryKeys { get; set; }

    }

}

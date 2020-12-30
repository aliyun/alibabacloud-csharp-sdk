// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInventoryEntriesRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListInventoryEntriesRequestFilter> Filter { get; set; }
        public class ListInventoryEntriesRequestFilter : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

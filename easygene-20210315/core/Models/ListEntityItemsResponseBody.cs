// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListEntityItemsResponseBody : TeaModel {
        [NameInMap("EntityItems")]
        [Validation(Required=false)]
        public List<ListEntityItemsResponseBodyEntityItems> EntityItems { get; set; }
        public class ListEntityItemsResponseBodyEntityItems : TeaModel {
            [NameInMap("EntityData")]
            [Validation(Required=false)]
            public Dictionary<string, string> EntityData { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

        }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

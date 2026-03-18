// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListTablesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTablesResponseBodyData Data { get; set; }
        public class ListTablesResponseBodyData : TeaModel {
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            [NameInMap("tables")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyDataTables> Tables { get; set; }
            public class ListTablesResponseBodyDataTables : TeaModel {
                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

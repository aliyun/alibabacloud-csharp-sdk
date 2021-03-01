// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRootStacksResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRootStacksResponseBodyData Data { get; set; }
        public class ListRootStacksResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListRootStacksResponseBodyDataResult> Result { get; set; }
            public class ListRootStacksResponseBodyDataResult : TeaModel {
                public List<ListRootStacksResponseBodyDataResultChildren> Children { get; set; }
                public class ListRootStacksResponseBodyDataResultChildren : TeaModel {
                    public string Comment { get; set; }
                    public string Icon { get; set; }
                    public string Name { get; set; }
                    public long? Id { get; set; }
                }
                public ListRootStacksResponseBodyDataResultRoot Root { get; set; }
                public class ListRootStacksResponseBodyDataResultRoot : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListUserSuppressionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserSuppressionResponseBodyData Data { get; set; }
        public class ListUserSuppressionResponseBodyData : TeaModel {
            [NameInMap("UserSuppressions")]
            [Validation(Required=false)]
            public List<ListUserSuppressionResponseBodyDataUserSuppressions> UserSuppressions { get; set; }
            public class ListUserSuppressionResponseBodyDataUserSuppressions : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public int? CreateTime { get; set; }

                [NameInMap("LastBounceTime")]
                [Validation(Required=false)]
                public int? LastBounceTime { get; set; }

                [NameInMap("SuppressionId")]
                [Validation(Required=false)]
                public int? SuppressionId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

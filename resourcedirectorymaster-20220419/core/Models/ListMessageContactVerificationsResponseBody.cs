// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListMessageContactVerificationsResponseBody : TeaModel {
        [NameInMap("ContactVerifications")]
        [Validation(Required=false)]
        public List<ListMessageContactVerificationsResponseBodyContactVerifications> ContactVerifications { get; set; }
        public class ListMessageContactVerificationsResponseBodyContactVerifications : TeaModel {
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

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

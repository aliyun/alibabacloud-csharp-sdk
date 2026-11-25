// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDeviceBelongIdentifiersResponseBody : TeaModel {
        [NameInMap("Identifiers")]
        [Validation(Required=false)]
        public List<ListDeviceBelongIdentifiersResponseBodyIdentifiers> Identifiers { get; set; }
        public class ListDeviceBelongIdentifiersResponseBodyIdentifiers : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("IdentifierId")]
            [Validation(Required=false)]
            public string IdentifierId { get; set; }

            [NameInMap("IdentifierType")]
            [Validation(Required=false)]
            public string IdentifierType { get; set; }

            [NameInMap("IdentifierValue")]
            [Validation(Required=false)]
            public string IdentifierValue { get; set; }

        }

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
        public long? TotalCount { get; set; }

    }

}

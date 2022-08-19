// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnCrossAccountAuthorizationsResponseBody : TeaModel {
        [NameInMap("CrossAccountAuthorizations")]
        [Validation(Required=false)]
        public List<DescribeVpnCrossAccountAuthorizationsResponseBodyCrossAccountAuthorizations> CrossAccountAuthorizations { get; set; }
        public class DescribeVpnCrossAccountAuthorizationsResponseBodyCrossAccountAuthorizations : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("BindInstance")]
            [Validation(Required=false)]
            public string BindInstance { get; set; }

            [NameInMap("BindProduct")]
            [Validation(Required=false)]
            public string BindProduct { get; set; }

            [NameInMap("BindUid")]
            [Validation(Required=false)]
            public long? BindUid { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListFederationsResponseBody : TeaModel {
        [NameInMap("Federations")]
        [Validation(Required=false)]
        public List<ListFederationsResponseBodyFederations> Federations { get; set; }
        public class ListFederationsResponseBodyFederations : TeaModel {
            [NameInMap("FederationId")]
            [Validation(Required=false)]
            public string FederationId { get; set; }

            [NameInMap("FileSystemIds")]
            [Validation(Required=false)]
            public string FileSystemIds { get; set; }

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

    }

}

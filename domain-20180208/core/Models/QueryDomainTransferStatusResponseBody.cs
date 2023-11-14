// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryDomainTransferStatusResponseBody : TeaModel {
        [NameInMap("DomainTransferStatus")]
        [Validation(Required=false)]
        public List<QueryDomainTransferStatusResponseBodyDomainTransferStatus> DomainTransferStatus { get; set; }
        public class QueryDomainTransferStatusResponseBodyDomainTransferStatus : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainStatusDescription")]
            [Validation(Required=false)]
            public string DomainStatusDescription { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

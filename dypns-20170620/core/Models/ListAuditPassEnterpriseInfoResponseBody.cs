// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class ListAuditPassEnterpriseInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAuditPassEnterpriseInfoResponseBodyData> Data { get; set; }
        public class ListAuditPassEnterpriseInfoResponseBodyData : TeaModel {
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public long? EnterpriseId { get; set; }

            [NameInMap("EnterpriseName")]
            [Validation(Required=false)]
            public string EnterpriseName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

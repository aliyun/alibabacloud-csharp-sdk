// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetAuditLogStatusResponseBody : TeaModel {
        [NameInMap("AuditLogStatus")]
        [Validation(Required=false)]
        public string AuditLogStatus { get; set; }

        [NameInMap("AuditOssBucket")]
        [Validation(Required=false)]
        public string AuditOssBucket { get; set; }

        [NameInMap("GrantedServiceAccess")]
        [Validation(Required=false)]
        public bool? GrantedServiceAccess { get; set; }

        [NameInMap("OssBuckets")]
        [Validation(Required=false)]
        public List<string> OssBuckets { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAuditSecurityIpResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public List<ListAuditSecurityIpResponseBodySecurityIpList> SecurityIpList { get; set; }
        public class ListAuditSecurityIpResponseBodySecurityIpList : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

            [NameInMap("Ips")]
            [Validation(Required=false)]
            public string Ips { get; set; }

            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

        }

    }

}

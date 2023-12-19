// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DiagnoseVpnConnectionsResponseBody : TeaModel {
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

        [NameInMap("VpnConnections")]
        [Validation(Required=false)]
        public List<DiagnoseVpnConnectionsResponseBodyVpnConnections> VpnConnections { get; set; }
        public class DiagnoseVpnConnectionsResponseBodyVpnConnections : TeaModel {
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            [NameInMap("FailedReasonCode")]
            [Validation(Required=false)]
            public string FailedReasonCode { get; set; }

            [NameInMap("FailedTime")]
            [Validation(Required=false)]
            public long? FailedTime { get; set; }

            [NameInMap("MismatchLocalParam")]
            [Validation(Required=false)]
            public string MismatchLocalParam { get; set; }

            [NameInMap("MismatchRemoteParam")]
            [Validation(Required=false)]
            public string MismatchRemoteParam { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("SourceLog")]
            [Validation(Required=false)]
            public string SourceLog { get; set; }

            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

        }

    }

}

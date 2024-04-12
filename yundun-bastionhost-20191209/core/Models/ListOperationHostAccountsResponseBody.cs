// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationHostAccountsResponseBody : TeaModel {
        [NameInMap("HostAccounts")]
        [Validation(Required=false)]
        public List<ListOperationHostAccountsResponseBodyHostAccounts> HostAccounts { get; set; }
        public class ListOperationHostAccountsResponseBodyHostAccounts : TeaModel {
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            [NameInMap("HostAccountId")]
            [Validation(Required=false)]
            public string HostAccountId { get; set; }

            [NameInMap("HostAccountName")]
            [Validation(Required=false)]
            public string HostAccountName { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("HostShareKeyId")]
            [Validation(Required=false)]
            public string HostShareKeyId { get; set; }

            [NameInMap("PrivateKeyFingerprint")]
            [Validation(Required=false)]
            public string PrivateKeyFingerprint { get; set; }

            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            [NameInMap("SSHConfig")]
            [Validation(Required=false)]
            public ListOperationHostAccountsResponseBodyHostAccountsSSHConfig SSHConfig { get; set; }
            public class ListOperationHostAccountsResponseBodyHostAccountsSSHConfig : TeaModel {
                [NameInMap("EnableSFTPChannel")]
                [Validation(Required=false)]
                public bool? EnableSFTPChannel { get; set; }

                [NameInMap("EnableSSHChannel")]
                [Validation(Required=false)]
                public bool? EnableSSHChannel { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

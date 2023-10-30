// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListApproveCommandsResponseBody : TeaModel {
        [NameInMap("ApproveCommands")]
        [Validation(Required=false)]
        public List<ListApproveCommandsResponseBodyApproveCommands> ApproveCommands { get; set; }
        public class ListApproveCommandsResponseBodyApproveCommands : TeaModel {
            [NameInMap("ApproveCommandId")]
            [Validation(Required=false)]
            public string ApproveCommandId { get; set; }

            [NameInMap("AssetAccountName")]
            [Validation(Required=false)]
            public string AssetAccountName { get; set; }

            [NameInMap("AssetIp")]
            [Validation(Required=false)]
            public string AssetIp { get; set; }

            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("ClientUser")]
            [Validation(Required=false)]
            public string ClientUser { get; set; }

            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

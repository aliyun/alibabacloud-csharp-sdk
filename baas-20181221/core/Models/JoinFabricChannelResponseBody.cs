// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class JoinFabricChannelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<JoinFabricChannelResponseBodyResult> Result { get; set; }
        public class JoinFabricChannelResponseBodyResult : TeaModel {
            [NameInMap("WithPeer")]
            [Validation(Required=false)]
            public bool? WithPeer { get; set; }

            [NameInMap("AcceptTime")]
            [Validation(Required=false)]
            public string AcceptTime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("DestroyTime")]
            [Validation(Required=false)]
            public string DestroyTime { get; set; }

            [NameInMap("InviteTime")]
            [Validation(Required=false)]
            public string InviteTime { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("ConfirmTime")]
            [Validation(Required=false)]
            public string ConfirmTime { get; set; }

            [NameInMap("ApproveTime")]
            [Validation(Required=false)]
            public string ApproveTime { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}

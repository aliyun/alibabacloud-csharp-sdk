// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricChannelMembersResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeFabricChannelMembersResponseBodyResult> Result { get; set; }
        public class DescribeFabricChannelMembersResponseBodyResult : TeaModel {
            [NameInMap("AcceptTime")]
            [Validation(Required=false)]
            public string AcceptTime { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("InviteTime")]
            [Validation(Required=false)]
            public string InviteTime { get; set; }

            [NameInMap("OrganizationDescription")]
            [Validation(Required=false)]
            public string OrganizationDescription { get; set; }

            [NameInMap("OrganizationDomain")]
            [Validation(Required=false)]
            public string OrganizationDomain { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("OrganizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("WithPeer")]
            [Validation(Required=false)]
            public bool? WithPeer { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

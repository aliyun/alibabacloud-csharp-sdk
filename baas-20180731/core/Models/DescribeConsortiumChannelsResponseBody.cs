// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeConsortiumChannelsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeConsortiumChannelsResponseBodyResult> Result { get; set; }
        public class DescribeConsortiumChannelsResponseBodyResult : TeaModel {
            [NameInMap("BatchTimeout")]
            [Validation(Required=false)]
            public int? BatchTimeout { get; set; }

            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public int? BlockCount { get; set; }

            [NameInMap("ChaincodeCount")]
            [Validation(Required=false)]
            public int? ChaincodeCount { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("ConsortiumId")]
            [Validation(Required=false)]
            public string ConsortiumId { get; set; }

            [NameInMap("ConsortiumName")]
            [Validation(Required=false)]
            public string ConsortiumName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public string DeleteTime { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Hybird")]
            [Validation(Required=false)]
            public bool? Hybird { get; set; }

            /// <summary>
            /// Id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("MaxMessageCount")]
            [Validation(Required=false)]
            public int? MaxMessageCount { get; set; }

            [NameInMap("MemberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            [NameInMap("MemberJoinedCount")]
            [Validation(Required=false)]
            public string MemberJoinedCount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NeedJoined")]
            [Validation(Required=false)]
            public bool? NeedJoined { get; set; }

            [NameInMap("OwnerBid")]
            [Validation(Required=false)]
            public string OwnerBid { get; set; }

            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public int? OwnerUid { get; set; }

            [NameInMap("PreferredMaxBytes")]
            [Validation(Required=false)]
            public int? PreferredMaxBytes { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("SupportChannelConfig")]
            [Validation(Required=false)]
            public bool? SupportChannelConfig { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

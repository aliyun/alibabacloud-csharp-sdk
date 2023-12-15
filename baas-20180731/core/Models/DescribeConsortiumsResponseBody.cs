// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeConsortiumsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeConsortiumsResponseBodyResult> Result { get; set; }
        public class DescribeConsortiumsResponseBodyResult : TeaModel {
            [NameInMap("CAName")]
            [Validation(Required=false)]
            public string CAName { get; set; }

            [NameInMap("CAUrl")]
            [Validation(Required=false)]
            public string CAUrl { get; set; }

            [NameInMap("ChannelCount")]
            [Validation(Required=false)]
            public int? ChannelCount { get; set; }

            [NameInMap("ChannelPolicy")]
            [Validation(Required=false)]
            public string ChannelPolicy { get; set; }

            [NameInMap("CodeName")]
            [Validation(Required=false)]
            public string CodeName { get; set; }

            [NameInMap("ConsortiumId")]
            [Validation(Required=false)]
            public string ConsortiumId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("ExpireState")]
            [Validation(Required=false)]
            public string ExpireState { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("Hybrid")]
            [Validation(Required=false)]
            public bool? Hybrid { get; set; }

            [NameInMap("MSP")]
            [Validation(Required=false)]
            public string MSP { get; set; }

            [NameInMap("MajorVersion")]
            [Validation(Required=false)]
            public string MajorVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OrdererCount")]
            [Validation(Required=false)]
            public int? OrdererCount { get; set; }

            [NameInMap("OrganizationCount")]
            [Validation(Required=false)]
            public int? OrganizationCount { get; set; }

            [NameInMap("OwnerBid")]
            [Validation(Required=false)]
            public string OwnerBid { get; set; }

            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("SupportChannelConfig")]
            [Validation(Required=false)]
            public bool? SupportChannelConfig { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeConsortiumsResponseBodyResultTags> Tags { get; set; }
            public class DescribeConsortiumsResponseBodyResultTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

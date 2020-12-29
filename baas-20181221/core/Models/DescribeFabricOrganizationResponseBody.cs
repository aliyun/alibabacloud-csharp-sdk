// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricOrganizationResponseBody : TeaModel {
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
        public DescribeFabricOrganizationResponseBodyResult Result { get; set; }
        public class DescribeFabricOrganizationResponseBodyResult : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("PeerCount")]
            [Validation(Required=false)]
            public int? PeerCount { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ConsortiumCount")]
            [Validation(Required=false)]
            public int? ConsortiumCount { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeFabricOrganizationResponseBodyResultTags> Tags { get; set; }
            public class DescribeFabricOrganizationResponseBodyResultTags : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }
            [NameInMap("CodeName")]
            [Validation(Required=false)]
            public string CodeName { get; set; }
            [NameInMap("OwnerBid")]
            [Validation(Required=false)]
            public string OwnerBid { get; set; }
            [NameInMap("OrganizationDescription")]
            [Validation(Required=false)]
            public string OrganizationDescription { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }
            [NameInMap("MSP")]
            [Validation(Required=false)]
            public string MSP { get; set; }
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("CAUrl")]
            [Validation(Required=false)]
            public string CAUrl { get; set; }
            [NameInMap("CANAME")]
            [Validation(Required=false)]
            public string CANAME { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }
            [NameInMap("OrganizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }
        };

    }

}

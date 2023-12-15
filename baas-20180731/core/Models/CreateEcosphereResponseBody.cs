// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateEcosphereResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateEcosphereResponseBodyResult Result { get; set; }
        public class CreateEcosphereResponseBodyResult : TeaModel {
            [NameInMap("ChannelCount")]
            [Validation(Required=false)]
            public int? ChannelCount { get; set; }

            [NameInMap("ChannelPolicy")]
            [Validation(Required=false)]
            public string ChannelPolicy { get; set; }

            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ConsortiumId")]
            [Validation(Required=false)]
            public string ConsortiumId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("MemberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OrdererCount")]
            [Validation(Required=false)]
            public int? OrdererCount { get; set; }

            [NameInMap("OrdererType")]
            [Validation(Required=false)]
            public string OrdererType { get; set; }

            [NameInMap("Organizations")]
            [Validation(Required=false)]
            public List<CreateEcosphereResponseBodyResultOrganizations> Organizations { get; set; }
            public class CreateEcosphereResponseBodyResultOrganizations : TeaModel {
                [NameInMap("ClusterState")]
                [Validation(Required=false)]
                public string ClusterState { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ServiceState")]
                [Validation(Required=false)]
                public string ServiceState { get; set; }

            }

            [NameInMap("OwnerBid")]
            [Validation(Required=false)]
            public string OwnerBid { get; set; }

            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ServiceState")]
            [Validation(Required=false)]
            public string ServiceState { get; set; }

            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

            [NameInMap("Specification")]
            [Validation(Required=false)]
            public CreateEcosphereResponseBodyResultSpecification Specification { get; set; }
            public class CreateEcosphereResponseBodyResultSpecification : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NumOfNodes")]
                [Validation(Required=false)]
                public int? NumOfNodes { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

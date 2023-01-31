// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcPrefixListAssociationsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrefixListAssociation")]
        [Validation(Required=false)]
        public List<GetVpcPrefixListAssociationsResponseBodyPrefixListAssociation> PrefixListAssociation { get; set; }
        public class GetVpcPrefixListAssociationsResponseBodyPrefixListAssociation : TeaModel {
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("ResourceUid")]
            [Validation(Required=false)]
            public string ResourceUid { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListAssociationsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [NameInMap("PrefixListAssociations")]
        [Validation(Required=false)]
        public DescribePrefixListAssociationsResponseBodyPrefixListAssociations PrefixListAssociations { get; set; }
        public class DescribePrefixListAssociationsResponseBodyPrefixListAssociations : TeaModel {
            [NameInMap("PrefixListAssociation")]
            [Validation(Required=false)]
            public List<DescribePrefixListAssociationsResponseBodyPrefixListAssociationsPrefixListAssociation> PrefixListAssociation { get; set; }
            public class DescribePrefixListAssociationsResponseBodyPrefixListAssociationsPrefixListAssociation : TeaModel {
                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// Details about the resources that are associated with the prefix list.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

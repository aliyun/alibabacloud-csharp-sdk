// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token that is returned in this call. If the return value is empty, no more data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Details about the resources that are associated with the prefix list.</para>
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
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp11ujym6xsff6l0****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>securitygroup</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38793DB8-A4B2-4AEC-BFD3-111234E9188D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

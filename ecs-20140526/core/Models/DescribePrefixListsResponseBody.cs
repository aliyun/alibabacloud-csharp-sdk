// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token that is returned in this call. If the return value is empty, no more data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public DescribePrefixListsResponseBodyPrefixLists PrefixLists { get; set; }
        public class DescribePrefixListsResponseBodyPrefixLists : TeaModel {
            [NameInMap("PrefixList")]
            [Validation(Required=false)]
            public List<DescribePrefixListsResponseBodyPrefixListsPrefixList> PrefixList { get; set; }
            public class DescribePrefixListsResponseBodyPrefixListsPrefixList : TeaModel {
                [NameInMap("AddressFamily")]
                [Validation(Required=false)]
                public string AddressFamily { get; set; }

                [NameInMap("AssociationCount")]
                [Validation(Required=false)]
                public int? AssociationCount { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("MaxEntries")]
                [Validation(Required=false)]
                public int? MaxEntries { get; set; }

                [NameInMap("PrefixListId")]
                [Validation(Required=false)]
                public string PrefixListId { get; set; }

                [NameInMap("PrefixListName")]
                [Validation(Required=false)]
                public string PrefixListName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePrefixListsResponseBodyPrefixListsPrefixListTags Tags { get; set; }
                public class DescribePrefixListsResponseBodyPrefixListsPrefixListTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribePrefixListsResponseBodyPrefixListsPrefixListTagsTag> Tag { get; set; }
                    public class DescribePrefixListsResponseBodyPrefixListsPrefixListTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38793DB8-A4B2-4AEC-BFD3-111234E9188D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

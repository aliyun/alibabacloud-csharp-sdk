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

        /// <summary>
        /// <para>Details about the prefix lists.</para>
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public DescribePrefixListsResponseBodyPrefixLists PrefixLists { get; set; }
        public class DescribePrefixListsResponseBodyPrefixLists : TeaModel {
            [NameInMap("PrefixList")]
            [Validation(Required=false)]
            public List<DescribePrefixListsResponseBodyPrefixListsPrefixList> PrefixList { get; set; }
            public class DescribePrefixListsResponseBodyPrefixListsPrefixList : TeaModel {
                /// <summary>
                /// <para>The IP address family of the prefix list. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IPv4</description></item>
                /// <item><description>IPv6</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("AddressFamily")]
                [Validation(Required=false)]
                public string AddressFamily { get; set; }

                /// <summary>
                /// <para>The number of associated resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AssociationCount")]
                [Validation(Required=false)]
                public int? AssociationCount { get; set; }

                /// <summary>
                /// <para>The time when the prefix list was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-02-20T07:11Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the prefix list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The maximum number of entries that the prefix list can contain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxEntries")]
                [Validation(Required=false)]
                public int? MaxEntries { get; set; }

                /// <summary>
                /// <para>The ID of the prefix list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-x1j1k5ykzqlixdcy****</para>
                /// </summary>
                [NameInMap("PrefixListId")]
                [Validation(Required=false)]
                public string PrefixListId { get; set; }

                /// <summary>
                /// <para>The name of the prefix list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrefixListNameSample</para>
                /// </summary>
                [NameInMap("PrefixListName")]
                [Validation(Required=false)]
                public string PrefixListName { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the prefix list belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags of the prefix list.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePrefixListsResponseBodyPrefixListsPrefixListTags Tags { get; set; }
                public class DescribePrefixListsResponseBodyPrefixListsPrefixListTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribePrefixListsResponseBodyPrefixListsPrefixListTagsTag> Tag { get; set; }
                    public class DescribePrefixListsResponseBodyPrefixListsPrefixListTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag value. A prefix list can have 1 to 20 tags. The tag value can be an empty string.</para>
                        /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http:// or https://</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag key. A prefix list can have 1 to 20 tags. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
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

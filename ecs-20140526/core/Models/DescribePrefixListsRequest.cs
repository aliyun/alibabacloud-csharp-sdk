// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePrefixListsRequest : TeaModel {
        /// <summary>
        /// <para>The IP address family. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4</description></item>
        /// <item><description>IPv6</description></item>
        /// </list>
        /// <para>This parameter is empty by default, which indicates that all prefix lists are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressFamily")]
        [Validation(Required=false)]
        public string AddressFamily { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the request to retrieve a new page of results. Set the value to the <c>NextToken</c> value returned in the last call to this operation. Leave this parameter empty the first time you call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of prefix lists. Valid values of N: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public List<string> PrefixListId { get; set; }

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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the prefix list belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags of the prefix list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribePrefixListsRequestTag> Tag { get; set; }
        public class DescribePrefixListsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the prefix list. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http:// or https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the prefix list. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http:// or https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

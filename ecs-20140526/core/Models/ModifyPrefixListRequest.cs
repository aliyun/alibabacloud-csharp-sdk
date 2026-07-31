// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPrefixListRequest : TeaModel {
        /// <summary>
        /// <para>The prefix list entries to add.</para>
        /// </summary>
        [NameInMap("AddEntry")]
        [Validation(Required=false)]
        public List<ModifyPrefixListRequestAddEntry> AddEntry { get; set; }
        public class ModifyPrefixListRequestAddEntry : TeaModel {
            /// <summary>
            /// <para>The Classless Inter-Domain Routing (CIDR) block of the prefix list entry to add. Valid values of N: 0 to 200.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>The total number of entries in the prefix list cannot exceed the maximum number of entries supported by the prefix list. You can invoke <a href="https://help.aliyun.com/document_detail/205872.html">DescribePrefixListAttributes</a> to query the maximum number of entries supported by a specified prefix list.</description></item>
            /// <item><description>Duplicate CIDR blocks are not allowed in Settings.</description></item>
            /// <item><description>The value cannot be the same as the value of the <c>RemoveEntry.N.Cidr</c> parameter.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the prefix list entry. The description must be 2 to 32 characters in length and cannot start with <c>http://</c> or <c>https://</c>. Valid values of N: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description Sample 01</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The description of the prefix list. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The prefix list ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// <para>The name of the prefix list. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c>, <c>https://</c>, <c>com.aliyun</c>, or <c>com.alibabacloud</c>. It can contain letters, Chinese characters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrefixListNameSample</para>
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The prefix list entries to delete.</para>
        /// </summary>
        [NameInMap("RemoveEntry")]
        [Validation(Required=false)]
        public List<ModifyPrefixListRequestRemoveEntry> RemoveEntry { get; set; }
        public class ModifyPrefixListRequestRemoveEntry : TeaModel {
            /// <summary>
            /// <para>The Classless Inter-Domain Routing (CIDR) block of the prefix list entry to delete. Valid values of N: 0 to 200.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>Duplicate CIDR blocks are not allowed in Settings.</description></item>
            /// <item><description>The value cannot be the same as the value of the <c>AddEntry.N.Cidr</c> parameter.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

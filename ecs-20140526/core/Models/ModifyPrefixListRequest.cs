// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPrefixListRequest : TeaModel {
        /// <summary>
        /// <para>The entries to be added to the prefix list.</para>
        /// </summary>
        [NameInMap("AddEntry")]
        [Validation(Required=false)]
        public List<ModifyPrefixListRequestAddEntry> AddEntry { get; set; }
        public class ModifyPrefixListRequestAddEntry : TeaModel {
            /// <summary>
            /// <para>The CIDR block in entry N to be added to the prefix list. Valid values of N: 0 to 200.</para>
            /// <para>Take note of the following items when you add the entries:</para>
            /// <list type="bullet">
            /// <item><description>The total number of entries in the prefix list cannot exceed the maximum number of entries you specified for the prefix list. You can call the <a href="https://help.aliyun.com/document_detail/205872.html">DescribePrefixListAttributes</a> operation to query the maximum number of entries that the prefix list can contain.</description></item>
            /// <item><description>You cannot specify duplicate CIDR blocks.</description></item>
            /// <item><description>The CIDR blocks cannot be the same as the <c>RemoveEntry.N.Cidr</c> values.</description></item>
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
            /// <para>The description in entry N. The description must be 2 to 32 characters in length and cannot start with <c>http://</c> or <c>https://</c>. Valid values of N: 0 to 200.</para>
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
        /// <para>The ID of the prefix list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-x1j1k5ykzqlixdcy****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// <para>The name of the prefix list. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c>, <c>https://</c>, <c>com.aliyun</c>, or <c>com.alibabacloud</c>. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrefixListNameSample</para>
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// <para>The region ID of the prefix list. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The entries to be deleted from the prefix list.</para>
        /// </summary>
        [NameInMap("RemoveEntry")]
        [Validation(Required=false)]
        public List<ModifyPrefixListRequestRemoveEntry> RemoveEntry { get; set; }
        public class ModifyPrefixListRequestRemoveEntry : TeaModel {
            /// <summary>
            /// <para>The CIDR block in entry N to be deleted from the prefix list. Valid values of N: 0 to 200.</para>
            /// <para>Take note of the following items when you delete the entries:</para>
            /// <list type="bullet">
            /// <item><description>You cannot specify duplicate CIDR blocks.</description></item>
            /// <item><description>The CIDR blocks cannot be the same as the <c>AddEntry.N.Cidr</c> values.</description></item>
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

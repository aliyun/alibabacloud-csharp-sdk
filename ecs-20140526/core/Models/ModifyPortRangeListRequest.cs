// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPortRangeListRequest : TeaModel {
        /// <summary>
        /// <para>The entries that you want to add or modify for the port list.</para>
        /// </summary>
        [NameInMap("AddEntry")]
        [Validation(Required=false)]
        public List<ModifyPortRangeListRequestAddEntry> AddEntry { get; set; }
        public class ModifyPortRangeListRequestAddEntry : TeaModel {
            /// <summary>
            /// <para>The description of the port range in entry N. The description must be 2 to 32 characters in length and cannot start with http:// or https://. Valid values of N: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The port range in entry N. Valid values of N: 0 to 200. Take note of the following limits:</para>
            /// <list type="bullet">
            /// <item><description>The total number of entries in the port list cannot exceed the <c>MaxEntries</c> value.</description></item>
            /// <item><description><c>PortRange</c> in different entries cannot be duplicated.</description></item>
            /// <item><description>The value of this parameter cannot be the same as the value of <c>RemoveEntry.N.PortRange</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the port list. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
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
        /// <para>The ID of the port list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prl-2ze9743****</para>
        /// </summary>
        [NameInMap("PortRangeListId")]
        [Validation(Required=false)]
        public string PortRangeListId { get; set; }

        /// <summary>
        /// <para>The name of the port list. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http://, https://, com.aliyun, or com.alibabacloud. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PortRangeListNameSample</para>
        /// </summary>
        [NameInMap("PortRangeListName")]
        [Validation(Required=false)]
        public string PortRangeListName { get; set; }

        /// <summary>
        /// <para>The region ID of the port list. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The entries that you want to remove from the port list.</para>
        /// </summary>
        [NameInMap("RemoveEntry")]
        [Validation(Required=false)]
        public List<ModifyPortRangeListRequestRemoveEntry> RemoveEntry { get; set; }
        public class ModifyPortRangeListRequestRemoveEntry : TeaModel {
            /// <summary>
            /// <para>The port range in entry N. Valid values of N: 0 to 200. Take note of the following limits:</para>
            /// <list type="bullet">
            /// <item><description><c>PortRange</c> in different entries cannot be duplicated.</description></item>
            /// <item><description>The value of this parameter cannot be the same as the value of <c>AddEntry.N.PortRange</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

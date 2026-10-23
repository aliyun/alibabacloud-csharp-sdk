// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePrefixListRequest : TeaModel {
        /// <summary>
        /// <para>The address family of the prefix list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4.</description></item>
        /// <item><description>IPv6.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressFamily")]
        [Validation(Required=false)]
        public string AddressFamily { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the prefix list. The description must be 2 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The prefix list entry information.</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public List<CreatePrefixListRequestEntry> Entry { get; set; }
        public class CreatePrefixListRequestEntry : TeaModel {
            /// <summary>
            /// <para>The Classless Inter-Domain Routing of the prefix list entry. Valid values of N: 0 to 200. Precautions:</para>
            /// <list type="bullet">
            /// <item><description>The number of entries in the prefix list cannot exceed the maximum number of entries (<c>MaxEntries</c>).</description></item>
            /// <item><description>The type of the Classless Inter-Domain Routing in an entry is determined by the address family. A prefix list cannot contain both IPv4 and IPv6 Classless Inter-Domain Routing.</description></item>
            /// <item><description>Classless Inter-Domain Routing in multiple entries cannot be duplicate. For example, you cannot specify two Settings such as 192.168.1.0/24.</description></item>
            /// <item><description>You can specify a single IP address in the Settings, and the system automatically transforms it into a Classless Inter-Domain Routing. For example, if you specify 192.168.1.100 in the Settings, the system automatically transforms it into 192.168.1.100/32.</description></item>
            /// <item><description>If you use an IPv6 Classless Inter-Domain Routing, the system automatically transforms it into a zero-compressed format and transforms letters to lowercase. For example, if you specify 2001:0DB8:0000:0000:0000:0000:0000:0000/32 in the Settings, the system automatically transforms it into 2001:db8::/32.</description></item>
            /// </list>
            /// <para>For more information about Classless Inter-Domain Routing, see <a href="~~185311#598efe6ef1v00~~">What is CIDR</a>.</para>
            /// <para>Default value: empty.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The description of the prefix list entry. The description must be 2 to 32 characters in length, and cannot start with <c>http://</c> or <c>https://</c>. Valid values of N: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description Sample 01</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries supported by the prefix list. Valid values: 1 to 200.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxEntries")]
        [Validation(Required=false)]
        public int? MaxEntries { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the prefix list. The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It cannot start with <c>http://</c>, <c>https://</c>, <c>com.aliyun</c>, or <c>com.alibabacloud</c>. It can contain Chinese characters, letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrefixListNameSample</para>
        /// </summary>
        [NameInMap("PrefixListName")]
        [Validation(Required=false)]
        public string PrefixListName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePrefixListRequestTag> Tag { get; set; }
        public class CreatePrefixListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the prefix list. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the prefix list. Valid values of N: 1 to 20. This parameter can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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

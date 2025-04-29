// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePortRangeListRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the port list. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description information of PortRangeList</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The port list entries.</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public List<CreatePortRangeListRequestEntry> Entry { get; set; }
        public class CreatePortRangeListRequestEntry : TeaModel {
            /// <summary>
            /// <para>The description of port range N. The description must be 2 to 32 characters in length and cannot start with http:// or https://. Valid values of N: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description information of Entry</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Port range N. Valid values of N: 0 to 200.</para>
            /// <list type="bullet">
            /// <item><description>The total number of entries cannot exceed the <c>MaxEntries</c> value.</description></item>
            /// <item><description><c>PortRange</c> in multiple entries cannot be duplicated.</description></item>
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
        /// <para>The maximum number of entries in the port list. The value cannot be changed after you create the port list. Valid values: 1 to 2000.</para>
        /// <remarks>
        /// <para> When you reference a port list in a resource, such as a security group, the maximum number of entries (instead of the actual number of entries) in the port list counts against the rule quota for the resource. Set a proper value for MaxEntries.</para>
        /// </remarks>
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
        /// <para>The name of the port list. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with http://, https://, com.aliyun, or com.alibabacloud. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The ID of the resource group to which the port list belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3b6jzp66****</para>
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
        /// <para>The tags to add to the port list. You can add 0 to 20 tags to the port list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePortRangeListRequestTag> Tag { get; set; }
        public class CreatePortRangeListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the port list.</para>
            /// <para>The tag key cannot be empty or an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key for PortRangeList</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the port list.</para>
            /// <para>The tag value cannot be empty but can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value for PortRangeList</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

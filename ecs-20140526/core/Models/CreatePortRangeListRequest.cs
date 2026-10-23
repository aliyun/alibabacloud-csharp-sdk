// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePortRangeListRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate the value from your client and make sure that the value is unique across different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the port list. The description must be 2 to 256 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description information of PortRangeList</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The array of port list entries.</para>
        /// </summary>
        [NameInMap("Entry")]
        [Validation(Required=false)]
        public List<CreatePortRangeListRequestEntry> Entry { get; set; }
        public class CreatePortRangeListRequestEntry : TeaModel {
            /// <summary>
            /// <para>The description of the port range. The description must be 2 to 32 characters in length, and cannot start with http:// or https://. Valid values of N: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description information of Entry</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The port range. Valid values of N: 0 to 200.</para>
            /// <list type="bullet">
            /// <item><description><para>The number of entries cannot exceed the maximum number of entries (MaxEntries).</para>
            /// </description></item>
            /// <item><description><para>The PortRange values in multiple entries must be unique.</para>
            /// </description></item>
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
        /// <para>The maximum number of entries supported by the port list. This parameter cannot be modified after the port list is created. Valid values: 1 to 2000.</para>
        /// <remarks>
        /// <para>Notice: When a port list is associated with a resource such as a security group, the rule quota is calculated based on the maximum number of entries rather than the actual number of entries. Set this parameter properly.</para>
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
        /// <para>The name of the port list. The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It cannot start with http://, https://, com.aliyun, or com.alibabacloud. It can contain Chinese characters, English letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PortRangeListNameSample</para>
        /// </summary>
        [NameInMap("PortRangeListName")]
        [Validation(Required=false)]
        public string PortRangeListName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the latest Alibaba Cloud regions.</para>
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
        /// <para>The array of tags bound to the port list. The array length ranges from 0 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePortRangeListRequestTag> Tag { get; set; }
        public class CreatePortRangeListRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the port list.</para>
            /// <para>When you use this parameter, it cannot be left empty or set to an empty string. It can be up to 128 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key for PortRangeList</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the port list.</para>
            /// <para>When you use this parameter, it cannot be left empty, but it can be set to an empty string. It can be up to 128 characters in length, and cannot contain http:// or https://.</para>
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

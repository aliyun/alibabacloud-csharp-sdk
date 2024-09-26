// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeVirtualNodesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency of requests?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The maximum number of resources that are allowed to return for this request. Default value: 20. Maximum value: 20.</para>
        /// <remarks>
        /// <para> The number of returned resources is less than or equal to the specified number.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is empty, all results have been returned.</para>
        /// <para>You do not need to specify this parameter in the first request. From the second request, you can obtain the token from the result returned by the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-****-b16db43be5bc</para>
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
        /// <para>The region ID of the virtual nodes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-uf66jeqopgqa9hdn****</para>
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
        /// <para>The status of the virtual node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending</description></item>
        /// <item><description>Ready</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags that are bound to the virtual node.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVirtualNodesRequestTag> Tag { get; set; }
        public class DescribeVirtualNodesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the virtual nodes. You can specify up to 20 IDs. Each ID must be a string in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vnd-2ze960zkdqrldeaw****&quot;,&quot;vnd-3ebzcviqbwt25dsz****&quot;]</para>
        /// </summary>
        [NameInMap("VirtualNodeIds")]
        [Validation(Required=false)]
        public string VirtualNodeIds { get; set; }

        /// <summary>
        /// <para>The names of the virtual nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testNode</para>
        /// </summary>
        [NameInMap("VirtualNodeName")]
        [Validation(Required=false)]
        public string VirtualNodeName { get; set; }

    }

}

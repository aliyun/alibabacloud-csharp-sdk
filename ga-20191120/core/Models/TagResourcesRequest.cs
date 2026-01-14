// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the region where the GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to which you want to add tags.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>ResourceType</b> to <b>accelerator</b>, set the value of ResourceId to the ID of a standard GA instance.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>basicaccelerator</b>, set the value of ResourceId to the ID of a basic GA instance.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>bandwidthpackage</b>, set the value of ResourceId to the ID of a bandwidth plan.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>acl</b>, set the value of ResourceId to the ID of an ACL.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>endpointgroup</b>, set the value of ResourceId to the ID of an endpoint group.</description></item>
        /// </list>
        /// <para>This parameter is required. You can enter up to 50 GA resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource to which you want to add tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accelerator:</b> a standard GA instance.</description></item>
        /// <item><description><b>basicaccelerator:</b> a basic GA instance.</description></item>
        /// <item><description><b>bandwidthpackage:</b> a bandwidth plan.</description></item>
        /// <item><description><b>acl:</b> an ACL.</description></item>
        /// <item><description><b>endpointgroup:</b> an endpoint group of a standard GA instance. You cannot call the TagResources operation to add tags to an endpoint group of a basic GA instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accelerator</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of GA resources.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the GA resource. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the GA resource. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>client token</b> can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the value of <b>RequestId</b> as the value of <b>ClientToken</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the new resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzrnd67gq****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

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
        /// <para>The ID of the GA resource.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>ResourceType</b> to <b>accelerator</b>, set the value of ResourceId to the ID of a standard GA instance.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>basicaccelerator</b>, set the value of ResourceId to the ID of a basic GA instance.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>bandwidthpackage</b>, set the value of ResourceId to the ID of a bandwidth plan.</description></item>
        /// <item><description>If you set <b>ResourceType</b> to <b>acl</b>, set the value of ResourceId to the ID of an access control list (ACL).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp149u6o36qt1as9b****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the GA resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accelerator:</b> a standard GA instance.</description></item>
        /// <item><description><b>basicaccelerator:</b> a basic GA instance.</description></item>
        /// <item><description><b>bandwidthpackage:</b> a bandwidth plan.</description></item>
        /// <item><description><b>acl:</b> an ACL.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accelerator</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

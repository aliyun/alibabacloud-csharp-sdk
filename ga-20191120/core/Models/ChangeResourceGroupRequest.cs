// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of a request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
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
        /// <para>The region ID of the Alibaba Cloud Global Accelerator (GA) instance. Set the value to <b>ap-southeast-1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the Global Accelerator resource for which you want to modify the resource group.</para>
        /// <list type="bullet">
        /// <item><description>If <b>ResourceType</b> is set to <b>accelerator</b>, set this parameter to the instance ID of a standard Global Accelerator instance.</description></item>
        /// <item><description>If <b>ResourceType</b> is set to <b>basicaccelerator</b>, set this parameter to the instance ID of a basic Global Accelerator instance.</description></item>
        /// <item><description>If <b>ResourceType</b> is set to <b>bandwidthpackage</b>, set this parameter to the ID of a bandwidth plan.</description></item>
        /// <item><description>If <b>ResourceType</b> is set to <b>acl</b>, set this parameter to the ID of an access control policy group.</description></item>
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
        /// <para>The type of the Global Accelerator resource for which you want to modify the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accelerator</b>: a standard Alibaba Cloud Global Accelerator (GA) instance.</description></item>
        /// <item><description><b>basicaccelerator</b>: a basic Alibaba Cloud Global Accelerator (GA) instance.</description></item>
        /// <item><description><b>bandwidthpackage</b>: a bandwidth plan.</description></item>
        /// <item><description><b>acl</b>: an access control policy group.</description></item>
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

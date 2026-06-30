// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class EnableAgentRuntimeRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The security group ID used to create an endpoint.</para>
        /// <para><b>If not specified</b>: The system automatically creates a security group named <b>sg-aliyun-rds-created-supabase-sandbox</b> in the VPC where the instance resides. No manual operation is required.</para>
        /// <para><b>If specified</b>: Ensure that the specified security group allows the CIDR block of the VPC where the Supabase instance resides (both inbound and outbound directions must be allowed). Otherwise, network connectivity issues may occur.</para>
        /// <remarks>
        /// <para>Notice: The endpoint is created only once. When the first Supabase instance in a VPC enables the sandbox and Edge Routine capabilities, the system automatically creates the endpoint. When subsequent Supabase instances in the same VPC enable this capability, the existing endpoint is reused and no new endpoint is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp179qkbvlj8ym*****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID used to create an endpoint. If this parameter is not specified, the vSwitch of the Supabase instance is used by default.</para>
        /// <remarks>
        /// <para>Notice: The endpoint is created only once. When the first Supabase instance in a VPC enables the sandbox and Edge Routine capabilities, the system automatically creates the endpoint. When subsequent Supabase instances in the same VPC enable this capability, the existing endpoint is reused and no new endpoint is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-9dp2hkpm22gxscfgy****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}

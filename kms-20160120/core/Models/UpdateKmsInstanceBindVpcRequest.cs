// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateKmsInstanceBindVpcRequest : TeaModel {
        /// <summary>
        /// <para>The VPC configuration. Each VPC configuration contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>VpcId: The ID of the VPC.</para>
        /// </description></item>
        /// <item><description><para>VSwitchId: The vSwitch in the VPC.</para>
        /// </description></item>
        /// <item><description><para>RegionID: The region where the VPC resides.</para>
        /// </description></item>
        /// <item><description><para>VpcOwnerId: The Alibaba Cloud account that owns the VPC.</para>
        /// </description></item>
        /// </list>
        /// <para>The value is a JSON string in the following format: <c>[{&quot;VpcId&quot;:&quot;${VpcId}&quot;,&quot;VSwitchId&quot;:&quot;${VSwitchId}&quot;,&quot;RegionId&quot;:&quot;${RegionId}&quot;,&quot;VpcOwnerId&quot;:${VpcOwnerId}},...]</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VpcId&quot;:&quot;vpc-bp1go9qvmj78j4f4c****&quot;,&quot;VSwitchId&quot;:&quot;vsw-bp16c5pvvcf0fp5b9****&quot;,&quot;RegionId&quot;:&quot;cn-hangzhou&quot;,&quot;VpcOwnerId&quot;:120708975881****},{&quot;VpcId&quot;:&quot;vpc-bp14c07ucxg6h1xjm****&quot;,&quot;VSwitchId&quot;:&quot;vsw-bp1wujtnspi1l3gvu****&quot;,&quot;RegionId&quot;:&quot;cn-hangzhou&quot;,&quot;VpcOwnerId&quot;:119285303511****}]</para>
        /// </summary>
        [NameInMap("BindVpcs")]
        [Validation(Required=false)]
        public string BindVpcs { get; set; }

        /// <summary>
        /// <para>The ID of the KMS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-phzz64f722a1buamw0****</para>
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

    }

}

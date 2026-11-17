// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressBatchRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the cloud service instance to which you want to attach the EIPs.</para>
        /// <para>You can enter the instance ID of a NAT gateway instance or a secondary elastic network interface controller (NIC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-hp3akk9irtd69jad****</para>
        /// </summary>
        [NameInMap("BindedInstanceId")]
        [Validation(Required=false)]
        public string BindedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance to which you want to attach the EIPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Nat</b>: NAT gateway.</description></item>
        /// <item><description><b>NetworkInterface</b>: secondary elastic network interface controller (NIC).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nat</para>
        /// </summary>
        [NameInMap("BindedInstanceType")]
        [Validation(Required=false)]
        public string BindedInstanceType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of EIPs that you want to associate with the cloud service instance.</para>
        /// <para>You must specify at least one EIP and can specify up to 50 EIPs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The association mode. Set the value to <b>MULTI_BINDED</b>, which indicates the multi-EIP to ENI mode.</para>
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>NetworkInterface</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MULTI_BINDED</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the EIPs that you want to associate with the cloud service instances.
        /// You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

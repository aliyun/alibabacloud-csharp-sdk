// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressBatchRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud service instance that you want to attach the EIPs to.</para>
        /// <para>You can enter the instance ID of an Internet NAT gateway instance or a secondary elastic network interfaces (ENIs) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-hp3akk9irtd69jad****</para>
        /// </summary>
        [NameInMap("BindedInstanceId")]
        [Validation(Required=false)]
        public string BindedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance that you want to attach the EIPs to. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Nat</b>: Internet NAT gateway.</description></item>
        /// <item><description><b>NetworkInterface</b>: secondary elastic network interfaces (ENIs).</description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
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
        /// <para>You must specify at least 1 EIP and can specify up to 50 EIPs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The association mode. Set the value to <b>MULTI_BINDED</b>, which specifies the multi-EIP-to-ENI mode.</para>
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
        /// <para>The region ID of the EIPs that you want to associate with a cloud service instance.
        /// You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
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

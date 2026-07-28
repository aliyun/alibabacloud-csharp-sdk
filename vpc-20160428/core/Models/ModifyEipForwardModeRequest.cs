// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyEipForwardModeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the EIP instance to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-j5ebhbw3br92fy****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The binding mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NAT</b> (default): NAT mode (standard mode).</para>
        /// </description></item>
        /// <item><description><para><b>MULTI_BINDED</b>: multi-EIP to ENI mode.</para>
        /// </description></item>
        /// <item><description><para><b>BINDED</b>: EIP to ENI mode.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when <b>InstanceType</b> is set to <b>NetworkInterface</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BINDED</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the EIP. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query region IDs.</para>
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

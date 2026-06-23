// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class EnablePhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to bypass the service provider (SP) subscription lifecycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Bypasses the SP subscription lifecycle. This means the instance is no longer managed by the Alibaba Cloud subscription system.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Does not bypass the SP subscription lifecycle.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To use this feature, contact your account manager.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ByPassSp")]
        [Validation(Required=false)]
        public bool? ByPassSp { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request.</para>
        /// <para>The token must be unique across requests. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the physical connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zeoaxkq3x****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the physical connection is located.</para>
        /// <para>You can call <c>DescribeRegions</c> to get the latest region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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

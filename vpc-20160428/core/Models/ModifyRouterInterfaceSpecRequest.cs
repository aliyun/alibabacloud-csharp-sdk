// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceSpecRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
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
        /// <para>The region where the router interface is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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

        /// <summary>
        /// <para>The ID of the router interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2zeo3xzyf38r4urzd****</para>
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

        /// <summary>
        /// <para>The specification of the router interface. The following table describes the available specifications and the corresponding bandwidths:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Mini.2</b>: 2 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Mini.5</b>: 5 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Small.1</b>: 10 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Small.2</b>: 20 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Small.5</b>: 50 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Middle.1</b>: 100 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Middle.2</b>: 200 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Middle.5</b>: 500 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Large.1</b>: 1000 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Large.2</b>: 2000 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Large.5</b>: 5000 Mbps</para>
        /// </description></item>
        /// <item><description><para><b>Xlarge.1</b>: 10000 Mbps</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>Role</b> is set to <b>AcceptingSide</b> (accepter), set <b>Spec</b> to <b>Negative</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Small.1</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}

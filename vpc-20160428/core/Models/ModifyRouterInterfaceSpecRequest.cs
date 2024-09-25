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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>The ID of the region where the router interface is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The specification of the router interface. Valid specifications and bandwidth values:</para>
        /// <list type="bullet">
        /// <item><description><b>Mini.2</b>: 2 Mbit/s</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbit/s</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbit/s</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbit/s</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbit/s</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbit/s</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbit/s</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbit/s</description></item>
        /// <item><description><b>Large.1</b>: 1,000 Mbit/s</description></item>
        /// <item><description><b>Large.2</b>: 2,000 Mbit/s</description></item>
        /// <item><description><b>Large.5</b>: 5,000 Mbit/s</description></item>
        /// <item><description><b>Xlarge.1</b>: 10,000 Mbit/s</description></item>
        /// </list>
        /// <remarks>
        /// <para> When <b>Role</b> is set to <b>AcceptingSide</b>, set <b>Spec</b> to <b>Negative</b>.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class MultiClusterNetworksValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>network1</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGateway")]
        [Validation(Required=false)]
        public bool? EnableGateway { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8.16x.1x.1x:15443</para>
        /// </summary>
        [NameInMap("CustomGatewayAddress")]
        [Validation(Required=false)]
        public string CustomGatewayAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asm-cross-network-ccb37ff104***</para>
        /// </summary>
        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

    }

}

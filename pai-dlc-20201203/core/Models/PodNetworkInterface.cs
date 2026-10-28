// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class PodNetworkInterface : TeaModel {
        /// <summary>
        /// <para>The name of the network interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eth0</para>
        /// </summary>
        [NameInMap("InterfaceName")]
        [Validation(Required=false)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// <para>The IP address of the network interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.1.2</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssignPrivateIpAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The set of information about the elastic network interface controller (NIC) to which secondary private IP addresses are assigned.</para>
        /// </summary>
        [NameInMap("AssignedPrivateIpAddressesSet")]
        [Validation(Required=false)]
        public AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet AssignedPrivateIpAddressesSet { get; set; }
        public class AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-uf620pb4d19ljnu4a64m</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The assigned private IP addresses.</para>
            /// </summary>
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<string> PrivateIpSet { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

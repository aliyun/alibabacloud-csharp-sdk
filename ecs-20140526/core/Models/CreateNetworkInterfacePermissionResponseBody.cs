// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfacePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of information composed of the Elastic network interface controller (NIC) permission list.</para>
        /// </summary>
        [NameInMap("NetworkInterfacePermission")]
        [Validation(Required=false)]
        public CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission NetworkInterfacePermission { get; set; }
        public class CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission : TeaModel {
            /// <summary>
            /// <para>The account ID of the Alibaba Cloud partner (certified ISV).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the Elastic network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp14v2sdd3v8htln****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ID of the Elastic network interface controller (NIC) permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-perm-bp1cs4lwn56lfb****</para>
            /// </summary>
            [NameInMap("NetworkInterfacePermissionId")]
            [Validation(Required=false)]
            public string NetworkInterfacePermissionId { get; set; }

            /// <summary>
            /// <para>The Elastic network interface controller (NIC) permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceAttach</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>The state of the Elastic network interface controller (NIC) permission. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The authorization is in progress.</description></item>
            /// <item><description>Granted: The authorization is granted.</description></item>
            /// <item><description>Revoking: The authorization is being revoked.</description></item>
            /// <item><description>Revoked: The authorization is revoked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Granted</para>
            /// </summary>
            [NameInMap("PermissionState")]
            [Validation(Required=false)]
            public string PermissionState { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FCD3DEF-63D3-4605-A818-805C8BD7DB87</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

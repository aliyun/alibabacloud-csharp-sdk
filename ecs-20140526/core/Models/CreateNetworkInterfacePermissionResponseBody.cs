// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfacePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ENI permission.</para>
        /// </summary>
        [NameInMap("NetworkInterfacePermission")]
        [Validation(Required=false)]
        public CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission NetworkInterfacePermission { get; set; }
        public class CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud partner (certified ISV) account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ENI ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp14v2sdd3v8htln****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The ENI permission ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-perm-bp1cs4lwn56lfb****</para>
            /// </summary>
            [NameInMap("NetworkInterfacePermissionId")]
            [Validation(Required=false)]
            public string NetworkInterfacePermissionId { get; set; }

            /// <summary>
            /// <para>The ENI permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceAttach</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>The ENI permission state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The permission is being granted.</description></item>
            /// <item><description>Granted: The permission has been granted.</description></item>
            /// <item><description>Revoking: The permission is being revoked.</description></item>
            /// <item><description>Revoked: The permission has been revoked.</description></item>
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

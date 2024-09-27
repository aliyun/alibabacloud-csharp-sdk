// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the ENI permissions.</para>
        /// </summary>
        [NameInMap("NetworkInterfacePermissions")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions NetworkInterfacePermissions { get; set; }
        public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions : TeaModel {
            [NameInMap("NetworkInterfacePermission")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission> NetworkInterfacePermission { get; set; }
            public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud partner (a certified ISV) or individual user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The ID of ENI N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-bp14v2sdd3v8htln****</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The ID of the ENI permission.</para>
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
                /// <para>The status of the ENI permission. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: The permission is being granted.</description></item>
                /// <item><description>Granted: The permission is granted.</description></item>
                /// <item><description>Revoking: The permission is being revoked.</description></item>
                /// <item><description>Revoked: The permission is revoked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Granted</para>
                /// </summary>
                [NameInMap("PermissionState")]
                [Validation(Required=false)]
                public string PermissionState { get; set; }

                /// <summary>
                /// <para>The name of the Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Elastic Compute Service</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FCD3DEF-63D3-4605-A818-805C8BD7DB87</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

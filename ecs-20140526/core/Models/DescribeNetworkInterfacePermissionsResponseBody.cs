// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacePermissionsResponseBody : TeaModel {
        [NameInMap("NetworkInterfacePermissions")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions NetworkInterfacePermissions { get; set; }
        public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions : TeaModel {
            [NameInMap("NetworkInterfacePermission")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission> NetworkInterfacePermission { get; set; }
            public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                [NameInMap("NetworkInterfacePermissionId")]
                [Validation(Required=false)]
                public string NetworkInterfacePermissionId { get; set; }

                [NameInMap("Permission")]
                [Validation(Required=false)]
                public string Permission { get; set; }

                [NameInMap("PermissionState")]
                [Validation(Required=false)]
                public string PermissionState { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the user group for which you want to query hosts.
        /// 
        /// >  You can call the [ListUserGroups](~~204509~~) operation to query the ID of the user group.
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<ListHostsForUserGroupResponseBodyHosts> Hosts { get; set; }
        public class ListHostsForUserGroupResponseBodyHosts : TeaModel {
            /// <summary>
            /// All Bastionhost API requests must include common request parameters. For more information about common request parameters, see [Common parameters](~~148139~~).
            /// 
            /// For more information about sample requests, see the "Examples" section of this topic.
            /// </summary>
            [NameInMap("ActiveAddressType")]
            [Validation(Required=false)]
            public string ActiveAddressType { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// ListHostsForUserGroup
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// WB662865
            /// </summary>
            [NameInMap("HostPrivateAddress")]
            [Validation(Required=false)]
            public string HostPrivateAddress { get; set; }

            /// <summary>
            /// Queries the hosts that a specified user group is authorized or not authorized to manage.
            /// </summary>
            [NameInMap("HostPublicAddress")]
            [Validation(Required=false)]
            public string HostPublicAddress { get; set; }

            /// <summary>
            /// ListHostsForUserGroup
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

        }

        /// <summary>
        /// The hosts returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The public endpoint of the host. The value is a domain name or an IP address.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsForUserRequest : TeaModel {
        /// <summary>
        /// The endpoint of the host that you want to query. You can set this parameter to a domain name or an IP address. Only exact match is supported.
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The name of the host that you want to query. Only exact match is supported.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the bastion host on which you want to query the hosts that the user is authorized or not authorized to manage.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies the category of the hosts that you want to query. Valid values:
        /// 
        /// *   **Authorized**: queries the hosts that the user is authorized to manage. This is the default value.
        /// *   **Unauthorized**: queries the hosts that the user is not authorized to manage.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The operating system of the host that you want to query. Valid values:
        /// 
        /// *   **Linux**
        /// *   **Windows**
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// The number of the page. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.\
        /// Maximum value: 100. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region ID of the bastion host on which you want to query the hosts that the user is authorized or not authorized to manage.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the user.
        /// 
        /// > You can call the [ListUsers](~~204522~~) operation to query the ID of the user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

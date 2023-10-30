// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsForUserRequest : TeaModel {
        /// <summary>
        /// The operating system of the host that you want to query. Valid values:
        /// 
        /// *   **Linux**
        /// *   **Windows**
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The ID of the Bastionhost instance where you want to query the hosts that the user is authorized or not authorized to manage.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the Bastionhost instance.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The category of the host that you want to query. Valid values:
        /// 
        /// *   **Authorized**: Query the hosts that the user is authorized to manage. This is the default value.
        /// *   **Unauthorized**: Query the hosts that the user is not authorized to manage.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The operating system of the host. Valid values:
        /// 
        /// *   **Linux**
        /// *   **Windows**
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The internal endpoint of the host. The value is a domain name or an IP address.
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// The endpoint type of the host. Valid values:
        /// 
        /// *   **Public**: a public endpoint
        /// *   **Private**: an internal endpoint
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// The value of the PageSize parameter must not exceed 100. Default value: 20. If you leave the PageSize parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave the PageSize parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The endpoint of the host that you want to query. You can set this parameter to a domain name or an IP address. Only exact match is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

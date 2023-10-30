// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsRequest : TeaModel {
        /// <summary>
        /// The address of the host that you want to query. You can set this parameter to a domain name or an IP address. Only exact match is supported.
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The ID of the host group to which the host to be queried belongs.
        /// 
        /// > You can call the [ListHostGroups](~~201307~~) operation to query the ID of the host group.
        /// </summary>
        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        /// <summary>
        /// The name of the host that you want to query. Only exact match is supported.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the bastion host on which you want to query hosts.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The region ID of the bastion host on which you want to query hosts.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The source of the host that you want to query. Valid values:
        /// 
        /// *   **Local**: a host in a data center
        /// *   **Ecs**: an Elastic Compute Service (ECS) instance
        /// *   **Rds**: a host in an ApsaraDB MyBase dedicated cluster
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The ID of the ECS instance or the host in an ApsaraDB MyBase dedicated cluster that you want to query. Only exact match is supported.
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// The status of the host that you want to query. Valid values:
        /// 
        /// *   **Normal**: normal
        /// *   **Release**: released
        /// </summary>
        [NameInMap("SourceInstanceState")]
        [Validation(Required=false)]
        public string SourceInstanceState { get; set; }

    }

}

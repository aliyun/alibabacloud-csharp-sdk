// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentHostsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query Elastic Compute Service (ECS) instances that are provided by Alibaba Cloud or to query hosts that are not provided by Alibaba Cloud. Valid values:
        /// 
        /// *   true (default value): queries all the ECS instances that are provided by Alibaba Cloud.
        /// *   false: queries all the hosts that are not provided by Alibaba Cloud.
        /// </summary>
        [NameInMap("AliyunHost")]
        [Validation(Required=false)]
        public bool? AliyunHost { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// The keyword that is used in fuzzy match.
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   10
        /// *   20
        /// *   50
        /// *   100
        /// 
        /// > Although Alibaba Cloud does not limit the maximum value of this parameter, we recommend that you do not set it to an excessively large value. If you set it to an excessively large value, a timeout error may occur.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The serial number of the host.
        /// 
        /// After the CloudMonitor agent is installed on a host, a globally unique serial number is generated. A host that is not provided by Alibaba Cloud has a serial number instead of an instance ID.
        /// 
        /// > This parameter can be used to accurately search for a monitored host.
        /// </summary>
        [NameInMap("SerialNumbers")]
        [Validation(Required=false)]
        public string SerialNumbers { get; set; }

        /// <summary>
        /// The status of the hosts that you want to query. Valid values:
        /// 
        /// *   Running: queries the hosts that are running.
        /// *   Stopped: queries the hosts that are stopped, are not installed, or fail to be installed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The status of SysOM. Valid values:
        /// 
        /// *   installing: SysOM is being installed.
        /// *   running: SysOM is running.
        /// *   stopped: SysOM is stopped.
        /// *   uninstalling: SysOM is being uninstalled.
        /// </summary>
        [NameInMap("SysomStatus")]
        [Validation(Required=false)]
        public string SysomStatus { get; set; }

    }

}

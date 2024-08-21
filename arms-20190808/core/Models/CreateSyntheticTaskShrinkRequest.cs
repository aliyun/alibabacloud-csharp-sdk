// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskShrinkRequest : TeaModel {
        /// <summary>
        /// The common parameters.
        /// </summary>
        [NameInMap("CommonParam")]
        [Validation(Required=false)]
        public string CommonParamShrink { get; set; }

        /// <summary>
        /// The file download task.
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public string DownloadShrink { get; set; }

        /// <summary>
        /// The frequency.
        /// </summary>
        [NameInMap("ExtendInterval")]
        [Validation(Required=false)]
        public string ExtendIntervalShrink { get; set; }

        /// <summary>
        /// The interval at which synthetic monitoring is performed. Unit: minutes. Valid values:
        /// 
        /// *   1
        /// *   5
        /// *   10
        /// *   15
        /// *   20
        /// *   30
        /// *   60
        /// *   120
        /// *   180
        /// *   240
        /// *   360
        /// *   480
        /// *   720
        /// *   1440
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        /// <summary>
        /// The interval type.
        /// 
        /// *   0: daily
        /// *   1: custom frequency
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        /// <summary>
        /// The IP address type:
        /// 
        /// *   0: an automatic IP address
        /// *   1: IPv4
        /// *   2: IPv6
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        /// <summary>
        /// The list of monitoring points.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorList")]
        [Validation(Required=false)]
        public string MonitorListShrink { get; set; }

        /// <summary>
        /// The monitoring items that are associated with the browse tasks.
        /// </summary>
        [NameInMap("Navigation")]
        [Validation(Required=false)]
        public string NavigationShrink { get; set; }

        /// <summary>
        /// The network synthetic monitoring task.
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string NetShrink { get; set; }

        /// <summary>
        /// The API performance synthetic monitoring task.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string ProtocolShrink { get; set; }

        /// <summary>
        /// The ID of the region in which the application is located.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the task. To update a synthetic monitoring task, enter the task name and set the **UpdateTask** parameter to **true**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the monitoring task. Valid values:
        /// 
        /// 1.  3: web page performance - IE
        /// 2.  34: web Page Performance - Chrome
        /// 3.  0: network quality
        /// 4.  40: file download
        /// 5.  7:API performance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        /// <summary>
        /// Specifies whether to update existing synthetic monitoring tasks.
        /// 
        /// *   true: updates existing synthetic monitoring tasks.
        /// *   false: creates new synthetic monitoring tasks.
        /// </summary>
        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        /// <summary>
        /// The URL for synthetic monitoring.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}

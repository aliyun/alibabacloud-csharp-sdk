// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeApplicationMonitorResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance on which the origin probing task runs.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The URL or IP address that is probed.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// Indicates whether the automatic diagnostics feature is enabled. Valid values:
        /// 
        /// *   **true**: yes.
        /// *   **false**: no
        /// </summary>
        [NameInMap("DetectEnable")]
        [Validation(Required=false)]
        public bool? DetectEnable { get; set; }

        /// <summary>
        /// The threshold that is used to trigger the automatic diagnostics feature.
        /// 
        /// If the liveness of the origin in percentile drops below the specified threshold, the automatic diagnostics feature is triggered.
        /// </summary>
        [NameInMap("DetectThreshold")]
        [Validation(Required=false)]
        public int? DetectThreshold { get; set; }

        /// <summary>
        /// The number of times that is required to reach the threshold before the automatic diagnostics feature can be triggered.
        /// </summary>
        [NameInMap("DetectTimes")]
        [Validation(Required=false)]
        public int? DetectTimes { get; set; }

        /// <summary>
        /// The list of probe points provided by the service provider.
        /// </summary>
        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public List<DescribeApplicationMonitorResponseBodyIspCityList> IspCityList { get; set; }
        public class DescribeApplicationMonitorResponseBodyIspCityList : TeaModel {
            /// <summary>
            /// The ID of the city where the probe point provided by the service provider is deployed.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The name of the city where the probe point provided by the service provider is deployed.
            /// </summary>
            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            /// <summary>
            /// The ID of the probe point provided by the service provider.
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// The name of the probe point provided by the service provider.
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

        }

        /// <summary>
        /// The ID of the listener on which the origin probing task runs.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The extended options of the listener protocol that is used by the origin probing task. The options vary based on the listener protocol.
        /// </summary>
        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. The value is set to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The silence period of the automatic diagnostics feature. This parameter specifies the interval at which the automatic diagnostics feature is triggered. If the availability rate does not return to normal after GA triggers an automatic diagnostic, GA must wait until the silence period ends before GA can trigger another automatic diagnostic.
        /// 
        /// If the number of consecutive times that the availability rate drops below the threshold of automatic diagnostics reaches the value of the **DetectTimes** parameter, the automatic diagnostics feature is triggered. The automatic diagnostics feature is not triggered again within the silence period even if the availability rate stays below the threshold. If the availability rate does not return to normal after the silence period ends, the automatic diagnostics feature is triggered again.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The ID of the origin probing task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The name of the origin probing task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}

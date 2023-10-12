// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeApplicationMonitorResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance on which the origin probing task ran.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The URL or IP address that was probed.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// Indicates whether the automatic diagnostics feature is enabled. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("DetectEnable")]
        [Validation(Required=false)]
        public bool? DetectEnable { get; set; }

        /// <summary>
        /// The threshold that is used to trigger automatic diagnostics.
        /// 
        /// If the availability of the origin server drops below the specified threshold, the automatic diagnostics feature is triggered.
        /// </summary>
        [NameInMap("DetectThreshold")]
        [Validation(Required=false)]
        public int? DetectThreshold { get; set; }

        /// <summary>
        /// The number of times that are required to reach the threshold before the automatic diagnostics feature is triggered.
        /// </summary>
        [NameInMap("DetectTimes")]
        [Validation(Required=false)]
        public int? DetectTimes { get; set; }

        /// <summary>
        /// The probe points of the Internet service provider (ISP).
        /// </summary>
        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public List<DescribeApplicationMonitorResponseBodyIspCityList> IspCityList { get; set; }
        public class DescribeApplicationMonitorResponseBodyIspCityList : TeaModel {
            /// <summary>
            /// The ID of the city where the probe point of the ISP is deployed.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// The name of the city where the probe point of the ISP is deployed.
            /// </summary>
            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            /// <summary>
            /// The probe point ID of the ISP.
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// The probe point name of the ISP.
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

        }

        /// <summary>
        /// The ID of the listener on which the origin probing task ran.
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
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The silence period of the automatic diagnostics feature. This parameter indicates the interval at which the automatic diagnostics feature is triggered. If the availability rate does not return to normal after GA triggers automatic diagnostics, GA must wait until the silence period ends before GA can trigger another automatic diagnostic.
        /// 
        /// If the number of consecutive times that the availability rate drops below the automatic diagnostics threshold reaches the value of **DetectTimes**, the automatic diagnostics feature is triggered. The automatic diagnostics feature is not triggered again within the silence period regardless of whether the availability rate remains below the threshold. If the availability rate does not return to normal after the silence period ends, the automatic diagnostics feature is triggered again.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The state of the application monitor task. Valid values:
        /// 
        /// - **init**
        /// 
        /// - **active**
        /// 
        /// - **updating**
        /// 
        /// - **inactive**
        /// 
        /// - **deleting**
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

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

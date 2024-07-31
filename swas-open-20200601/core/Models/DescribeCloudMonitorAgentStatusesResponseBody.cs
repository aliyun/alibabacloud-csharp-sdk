// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCloudMonitorAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the Cloud Monitor agent was automatically installed on the simple application server.
        /// </summary>
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<DescribeCloudMonitorAgentStatusesResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class DescribeCloudMonitorAgentStatusesResponseBodyInstanceStatusList : TeaModel {
            /// <summary>
            /// Indicates whether the Cloud Monitor agent was automatically installed on the simple application server. Valid values:
            /// 
            /// - true
            /// - false
            /// </summary>
            [NameInMap("AutoInstall")]
            [Validation(Required=false)]
            public bool? AutoInstall { get; set; }

            /// <summary>
            /// The ID of the simple application server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The running status of the Cloud Monitoring plug-in. Possible values are:
            /// 
            /// - running: Cloud Monitoring plug-in running.
            /// - stopped: Cloud Monitoring plug-in stopped.
            /// - installing: Cloud Monitoring plug-in installing.
            /// - install_faild: Cloud Monitoring plug-in installation failed.
            /// - abnormal: Cloud Monitoring plug-in installation abnormal.
            /// - not_installed: Cloud Monitoring plug-in not installed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

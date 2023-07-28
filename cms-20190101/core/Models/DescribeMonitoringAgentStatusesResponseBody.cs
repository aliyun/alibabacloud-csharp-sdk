// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// The status information.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the instance. Separate multiple instance IDs with commas (,).
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("NodeStatusList")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentStatusesResponseBodyNodeStatusList NodeStatusList { get; set; }
        public class DescribeMonitoringAgentStatusesResponseBodyNodeStatusList : TeaModel {
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentStatusesResponseBodyNodeStatusListNodeStatus> NodeStatus { get; set; }
            public class DescribeMonitoringAgentStatusesResponseBodyNodeStatusListNodeStatus : TeaModel {
                /// <summary>
                /// The error status of SysOM. Valid values:
                /// 
                /// *   `install_fail`: SysOM fails to be installed or an unknown error occurs.
                /// *   `install_assist_invalid`: SysOM fails to be installed because the status of Cloud Assistant is invalid.
                /// *   `install_assist_command_fail`: SysOM fails to be installed because the installation command fails to run.
                /// *   `uninstall_fail`: SysOM fails to be uninstalled or an unknown error occurs.
                /// *   `uninstall_assist_invalid`: SysOM fails to be uninstalled because the status of Cloud Assistant is invalid.
                /// *   `uninstall_assist_command_fail`: SysOM fails to be uninstalled because the uninstallation command fails to run.
                /// </summary>
                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public bool? AutoInstall { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("OsMonitorConfig")]
                [Validation(Required=false)]
                public string OsMonitorConfig { get; set; }

                [NameInMap("OsMonitorErrorCode")]
                [Validation(Required=false)]
                public string OsMonitorErrorCode { get; set; }

                [NameInMap("OsMonitorErrorDetail")]
                [Validation(Required=false)]
                public string OsMonitorErrorDetail { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("OsMonitorStatus")]
                [Validation(Required=false)]
                public string OsMonitorStatus { get; set; }

                [NameInMap("OsMonitorVersion")]
                [Validation(Required=false)]
                public string OsMonitorVersion { get; set; }

                /// <summary>
                /// The status of the CloudMonitor agent. Valid values:
                /// 
                /// *   running: The CloudMonitor agent is running.
                /// *   stopped: The CloudMonitor agent is stopped.
                /// *   installing: The CloudMonitor agent is being installed.
                /// *   install_faild: The CloudMonitor agent fails to be installed.
                /// *   abnormal: The CloudMonitor agent is not properly installed.
                /// *   not_installed: The CloudMonitor agent is not installed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The status of SysOM. Valid values:
        /// 
        /// *   installing: SysOM is being installed.
        /// *   running: SysOM is running.
        /// *   stopped: SysOM is stopped.
        /// *   uninstalling: SysOM is being uninstalled.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the CloudMonitor agent is automatically installed. Valid values:
        /// 
        /// *   true: The CloudMonitor agent is automatically installed.
        /// *   false: The CloudMonitor agent is not automatically installed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

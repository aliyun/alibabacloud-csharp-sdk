// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The host status information.
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
                /// The error code returned when the CloudMonitor agent is installed. Valid values:
                /// 
                /// *   Common.Timeout: The installation timed out.
                /// *   Common.SLR: The service-linked role for CloudMonitor is unauthorized.
                /// *   Common.OS: The operating system is not supported.
                /// *   Assist.Invalid: Cloud Assistant is not running.
                /// *   Assist.Invoke: An error occurred when the installation program is started.
                /// *   Assist.Execute: An error occurred when the installation program is running.
                /// </summary>
                [NameInMap("AgentInstallErrorCode")]
                [Validation(Required=false)]
                public string AgentInstallErrorCode { get; set; }

                /// <summary>
                /// Indicates whether the CloudMonitor agent is automatically installed. Valid values:
                /// 
                /// *   true: The CloudMonitor agent is automatically installed.
                /// *   false: The CloudMonitor agent is not automatically installed.
                /// </summary>
                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public bool? AutoInstall { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Indicates whether the SysAK monitoring feature is enabled.`` Valid values:
                /// 
                /// *   `true`: The SysAK monitoring feature is enabled.
                /// *   `false`: the SysAK monitoring feature is disabled.
                /// </summary>
                [NameInMap("OsMonitorConfig")]
                [Validation(Required=false)]
                public string OsMonitorConfig { get; set; }

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
                [NameInMap("OsMonitorErrorCode")]
                [Validation(Required=false)]
                public string OsMonitorErrorCode { get; set; }

                /// <summary>
                /// The details of the execution error. Valid values:
                /// 
                /// *   `Command.ErrorCode.Fail.Downlaod.REGIN_ID`: Failed to obtain the region ID.
                /// *   `Command.ErrorCode.Fail.Downlaod.SYSAK`: Failed to download the .rpm package of System Analyse Kit (SysAK).
                /// *   `Command.ErrorCode.Fail.Downlaod.CMON_FILE`: Failed to download the CMON file.
                /// *   `Command.ErrorCode.Fail.Downlaod.BTF`: Failed to start SysAK because the BTF file is not found.
                /// *   `Command.ErrorCode.Fail.Start.SYSAK`: Failed to start SysAK due to an unknown error.
                /// </summary>
                [NameInMap("OsMonitorErrorDetail")]
                [Validation(Required=false)]
                public string OsMonitorErrorDetail { get; set; }

                /// <summary>
                /// The status of SysOM. Valid values:
                /// 
                /// *   installing: SysOM is being installed.
                /// *   running: SysOM is running.
                /// *   stopped: SysOM is stopped.
                /// *   uninstalling: SysOM is being uninstalled.
                /// </summary>
                [NameInMap("OsMonitorStatus")]
                [Validation(Required=false)]
                public string OsMonitorStatus { get; set; }

                /// <summary>
                /// The SysOM version.
                /// </summary>
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

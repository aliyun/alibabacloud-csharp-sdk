// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The host status information.</para>
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
                /// <para>The error code returned when the CloudMonitor agent is installed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Common.Timeout: The installation timed out.</description></item>
                /// <item><description>Common.SLR: The service-linked role for CloudMonitor is unauthorized.</description></item>
                /// <item><description>Common.OS: The operating system is not supported.</description></item>
                /// <item><description>Assist.Invalid: Cloud Assistant is not running.</description></item>
                /// <item><description>Assist.Invoke: An error occurred when the installation program is started.</description></item>
                /// <item><description>Assist.Execute: An error occurred when the installation program is running.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("AgentInstallErrorCode")]
                [Validation(Required=false)]
                public string AgentInstallErrorCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the CloudMonitor agent is automatically installed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The CloudMonitor agent is automatically installed.</description></item>
                /// <item><description>false: The CloudMonitor agent is not automatically installed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public bool? AutoInstall { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-hp3dunahluwajv6f****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LoongCollectorStatus")]
                [Validation(Required=false)]
                public string LoongCollectorStatus { get; set; }

                [NameInMap("LoongCollectorVersion")]
                [Validation(Required=false)]
                public string LoongCollectorVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the SysAK monitoring feature is enabled.`` Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: The SysAK monitoring feature is enabled.</description></item>
                /// <item><description><c>false</c>: the SysAK monitoring feature is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;sysak&quot;:true}</para>
                /// </summary>
                [NameInMap("OsMonitorConfig")]
                [Validation(Required=false)]
                public string OsMonitorConfig { get; set; }

                /// <summary>
                /// <para>The error status of SysOM. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>install_fail</c>: SysOM fails to be installed or an unknown error occurs.</description></item>
                /// <item><description><c>install_assist_invalid</c>: SysOM fails to be installed because the status of Cloud Assistant is invalid.</description></item>
                /// <item><description><c>install_assist_command_fail</c>: SysOM fails to be installed because the installation command fails to run.</description></item>
                /// <item><description><c>uninstall_fail</c>: SysOM fails to be uninstalled or an unknown error occurs.</description></item>
                /// <item><description><c>uninstall_assist_invalid</c>: SysOM fails to be uninstalled because the status of Cloud Assistant is invalid.</description></item>
                /// <item><description><c>uninstall_assist_command_fail</c>: SysOM fails to be uninstalled because the uninstallation command fails to run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>install_fail</para>
                /// </summary>
                [NameInMap("OsMonitorErrorCode")]
                [Validation(Required=false)]
                public string OsMonitorErrorCode { get; set; }

                /// <summary>
                /// <para>The details of the execution error. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Command.ErrorCode.Fail.Downlaod.REGIN_ID</c>: Failed to obtain the region ID.</description></item>
                /// <item><description><c>Command.ErrorCode.Fail.Downlaod.SYSAK</c>: Failed to download the .rpm package of System Analyse Kit (SysAK).</description></item>
                /// <item><description><c>Command.ErrorCode.Fail.Downlaod.CMON_FILE</c>: Failed to download the CMON file.</description></item>
                /// <item><description><c>Command.ErrorCode.Fail.Downlaod.BTF</c>: Failed to start SysAK because the BTF file is not found.</description></item>
                /// <item><description><c>Command.ErrorCode.Fail.Start.SYSAK</c>: Failed to start SysAK due to an unknown error.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Command.ErrorCode.Fail.Downlaod.REGIN_ID</para>
                /// </summary>
                [NameInMap("OsMonitorErrorDetail")]
                [Validation(Required=false)]
                public string OsMonitorErrorDetail { get; set; }

                /// <summary>
                /// <para>The status of SysOM. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>installing: SysOM is being installed.</description></item>
                /// <item><description>running: SysOM is running.</description></item>
                /// <item><description>stopped: SysOM is stopped.</description></item>
                /// <item><description>uninstalling: SysOM is being uninstalled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("OsMonitorStatus")]
                [Validation(Required=false)]
                public string OsMonitorStatus { get; set; }

                /// <summary>
                /// <para>The SysOM version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.3.0-12</para>
                /// </summary>
                [NameInMap("OsMonitorVersion")]
                [Validation(Required=false)]
                public string OsMonitorVersion { get; set; }

                /// <summary>
                /// <para>The status of the CloudMonitor agent. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>running: The CloudMonitor agent is running.</description></item>
                /// <item><description>stopped: The CloudMonitor agent is stopped.</description></item>
                /// <item><description>installing: The CloudMonitor agent is being installed.</description></item>
                /// <item><description>install_faild: The CloudMonitor agent fails to be installed.</description></item>
                /// <item><description>abnormal: The CloudMonitor agent is not properly installed.</description></item>
                /// <item><description>not_installed: The CloudMonitor agent is not installed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F8371DF-AB81-41B8-9E1B-5493B3FF0E4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

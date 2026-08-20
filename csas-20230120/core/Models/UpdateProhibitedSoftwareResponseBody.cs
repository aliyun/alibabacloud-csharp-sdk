// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateProhibitedSoftwareResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2123E64A-FB25-561F-9988-B8781E430694</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the prohibited software.</para>
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public UpdateProhibitedSoftwareResponseBodySoftware Software { get; set; }
        public class UpdateProhibitedSoftwareResponseBodySoftware : TeaModel {
            /// <summary>
            /// <para>The time when the prohibited software was created, in the yyyy-MM-dd HH:mm:ss format. The time is displayed in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-17 09:49:03</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kxi3</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Linux operating system.</para>
            /// </summary>
            [NameInMap("LinuxProcesses")]
            [Validation(Required=false)]
            public List<UpdateProhibitedSoftwareResponseBodySoftwareLinuxProcesses> LinuxProcesses { get; set; }
            public class UpdateProhibitedSoftwareResponseBodySoftwareLinuxProcesses : TeaModel {
                /// <summary>
                /// <para>The bundle ID of the application. This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.aliyun.security.sase</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command line parameters for starting the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--start-minimized</para>
                /// </summary>
                [NameInMap("Cmdline")]
                [Validation(Required=false)]
                public string Cmdline { get; set; }

                /// <summary>
                /// <para>The directory where the process is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C:\\autotest</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kismain.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

            /// <summary>
            /// <para>The list of process configurations for the macOS operating system.</para>
            /// </summary>
            [NameInMap("MacOSProcesses")]
            [Validation(Required=false)]
            public List<UpdateProhibitedSoftwareResponseBodySoftwareMacOSProcesses> MacOSProcesses { get; set; }
            public class UpdateProhibitedSoftwareResponseBodySoftwareMacOSProcesses : TeaModel {
                /// <summary>
                /// <para>The bundle ID of the application. This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.autotest.app</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command line parameters for starting the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--start-minimized</para>
                /// </summary>
                [NameInMap("Cmdline")]
                [Validation(Required=false)]
                public string Cmdline { get; set; }

                /// <summary>
                /// <para>The directory where the process is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C:\\autotest</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QQPCTray.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

            /// <summary>
            /// <para>The name of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xshell</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the software prohibition policies that directly reference this prohibited software.</para>
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swb-c64076fa7afd****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

            /// <summary>
            /// <para>The IDs of the prohibited software tags associated with this prohibited software.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Windows operating system.</para>
            /// </summary>
            [NameInMap("WindowsProcesses")]
            [Validation(Required=false)]
            public List<UpdateProhibitedSoftwareResponseBodySoftwareWindowsProcesses> WindowsProcesses { get; set; }
            public class UpdateProhibitedSoftwareResponseBodySoftwareWindowsProcesses : TeaModel {
                /// <summary>
                /// <para>The bundle ID of the application. This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.aliyun.security.sase</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command line parameters for starting the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--start-minimized</para>
                /// </summary>
                [NameInMap("Cmdline")]
                [Validation(Required=false)]
                public string Cmdline { get; set; }

                /// <summary>
                /// <para>The directory where the process is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>C:\\autotest</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QQPCTray.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

        }

    }

}

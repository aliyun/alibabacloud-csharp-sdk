// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetProhibitedSoftwareResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F6DE3-3079-52DE-ABD1-39FB76B74FC9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The prohibited software details.</para>
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public GetProhibitedSoftwareResponseBodySoftware Software { get; set; }
        public class GetProhibitedSoftwareResponseBodySoftware : TeaModel {
            /// <summary>
            /// <para>The creation time of the prohibited software, in the yyyy-MM-dd HH:mm:ss format. The time is displayed in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-05 10:20:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P2P download tool</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the prohibited software is a system built-in prohibited software. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A system built-in prohibited software that is shared across all Alibaba Cloud accounts and cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: A custom prohibited software under the current Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Linux operating system.</para>
            /// </summary>
            [NameInMap("LinuxProcesses")]
            [Validation(Required=false)]
            public List<GetProhibitedSoftwareResponseBodySoftwareLinuxProcesses> LinuxProcesses { get; set; }
            public class GetProhibitedSoftwareResponseBodySoftwareLinuxProcesses : TeaModel {
                /// <summary>
                /// <para>The application bundle identifier (Bundle ID). This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.xunlei.Thunder</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command-line arguments for starting the process.</para>
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
                /// <para>C:\Program Files\Thunder Network\Thunder</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thuner.exe</para>
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
            public List<GetProhibitedSoftwareResponseBodySoftwareMacOSProcesses> MacOSProcesses { get; set; }
            public class GetProhibitedSoftwareResponseBodySoftwareMacOSProcesses : TeaModel {
                /// <summary>
                /// <para>The application bundle identifier (Bundle ID). This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.xunlei.Thunder</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command-line arguments for starting the process.</para>
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
                /// <para>C:\Program Files\Thunder Network\Thunder</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thuner.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

            /// <summary>
            /// <para>The name of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Thunder</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the software prohibition policies that directly reference the prohibited software.</para>
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// <para>The prohibited software ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swb-3e6a1f9c4b28****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

            /// <summary>
            /// <para>The IDs of the prohibited software tags associated with the prohibited software.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Windows operating system.</para>
            /// </summary>
            [NameInMap("WindowsProcesses")]
            [Validation(Required=false)]
            public List<GetProhibitedSoftwareResponseBodySoftwareWindowsProcesses> WindowsProcesses { get; set; }
            public class GetProhibitedSoftwareResponseBodySoftwareWindowsProcesses : TeaModel {
                /// <summary>
                /// <para>The application bundle identifier (Bundle ID). This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.xunlei.Thunder</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command-line arguments for starting the process.</para>
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
                /// <para>C:\Program Files\Thunder Network\Thunder</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thuner.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

        }

    }

}

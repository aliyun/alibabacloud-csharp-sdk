// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListProhibitedSoftwareResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7F49DCC-8EFE-59BE-8947-0529CC458C59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of prohibited software.</para>
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public List<ListProhibitedSoftwareResponseBodySoftware> Software { get; set; }
        public class ListProhibitedSoftwareResponseBodySoftware : TeaModel {
            /// <summary>
            /// <para>The time when the prohibited software was created, in the yyyy-MM-dd HH:mm:ss format. The time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-19 10:24:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P2P download software</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The collection of dynamic policy IDs that reference the prohibited software as a disposal action.</para>
            /// </summary>
            [NameInMap("DynamicPolicyIds")]
            [Validation(Required=false)]
            public List<string> DynamicPolicyIds { get; set; }

            /// <summary>
            /// <para>Indicates whether the software is a system built-in prohibited software. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A system built-in prohibited software that is shared across all Alibaba Cloud accounts and cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: Custom prohibited software under the current Alibaba Cloud account.</description></item>
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
            public List<ListProhibitedSoftwareResponseBodySoftwareLinuxProcesses> LinuxProcesses { get; set; }
            public class ListProhibitedSoftwareResponseBodySoftwareLinuxProcesses : TeaModel {
                /// <summary>
                /// <para>The application bundle identifier (Bundle ID). This parameter is required only for macOS processes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.autotest.app</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                /// <summary>
                /// <para>The command-line parameters for starting the process.</para>
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
                /// <para>/User/sase/Applications</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thunder</para>
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
            public List<ListProhibitedSoftwareResponseBodySoftwareMacOSProcesses> MacOSProcesses { get; set; }
            public class ListProhibitedSoftwareResponseBodySoftwareMacOSProcesses : TeaModel {
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
                /// <para>The command-line parameters for starting the process.</para>
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
                /// <para>~/Applications</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest.exe</para>
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
            /// <para>The collection of software prohibition policy IDs that directly reference the prohibited software.</para>
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swb-238eee6903e8****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

            /// <summary>
            /// <para>The collection of prohibited software tag IDs associated with the prohibited software.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Windows operating system.</para>
            /// </summary>
            [NameInMap("WindowsProcesses")]
            [Validation(Required=false)]
            public List<ListProhibitedSoftwareResponseBodySoftwareWindowsProcesses> WindowsProcesses { get; set; }
            public class ListProhibitedSoftwareResponseBodySoftwareWindowsProcesses : TeaModel {
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
                /// <para>The command-line parameters for starting the process.</para>
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
                /// <para>C:\Program Files\Thunder Network</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SASE.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of prohibited software entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}

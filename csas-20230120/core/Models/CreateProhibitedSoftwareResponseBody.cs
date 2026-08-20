// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedSoftwareResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B9AC7B08-80F5-5EDD-8E6B-033F2FE5D4E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the disabled software.</para>
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public CreateProhibitedSoftwareResponseBodySoftware Software { get; set; }
        public class CreateProhibitedSoftwareResponseBodySoftware : TeaModel {
            /// <summary>
            /// <para>The creation time of the disabled software, in the yyyy-MM-dd HH:mm:ss format. The time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-05 10:20:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the disabled software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint group targeting github</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Linux operating system.</para>
            /// </summary>
            [NameInMap("LinuxProcesses")]
            [Validation(Required=false)]
            public List<CreateProhibitedSoftwareResponseBodySoftwareLinuxProcesses> LinuxProcesses { get; set; }
            public class CreateProhibitedSoftwareResponseBodySoftwareLinuxProcesses : TeaModel {
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
                /// <para>C:\Program Files\Thunder Network\Thunder</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>terraform</para>
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
            public List<CreateProhibitedSoftwareResponseBodySoftwareMacOSProcesses> MacOSProcesses { get; set; }
            public class CreateProhibitedSoftwareResponseBodySoftwareMacOSProcesses : TeaModel {
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
                /// <para>C:\Program Files\Thunder Network\Thunder</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest_update.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

            /// <summary>
            /// <para>The software name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shell</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the disabled software.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swb-83995ff2ae38****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

            /// <summary>
            /// <para>The IDs of disabled software tags associated with this disabled software.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <para>The list of process configurations for the Windows operating system.</para>
            /// </summary>
            [NameInMap("WindowsProcesses")]
            [Validation(Required=false)]
            public List<CreateProhibitedSoftwareResponseBodySoftwareWindowsProcesses> WindowsProcesses { get; set; }
            public class CreateProhibitedSoftwareResponseBodySoftwareWindowsProcesses : TeaModel {
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
                /// <para>C:\Program Files\Thunder Network\Thunder</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The process name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anaconda3.exe</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

            }

        }

    }

}

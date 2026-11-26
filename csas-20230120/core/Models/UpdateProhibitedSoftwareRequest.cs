// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateProhibitedSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The description of the prohibited software.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of process configurations for the Linux operating system.</para>
        /// </summary>
        [NameInMap("LinuxProcesses")]
        [Validation(Required=false)]
        public List<UpdateProhibitedSoftwareRequestLinuxProcesses> LinuxProcesses { get; set; }
        public class UpdateProhibitedSoftwareRequestLinuxProcesses : TeaModel {
            /// <summary>
            /// <para>The bundle ID of the application. This parameter is required only for macOS processes. You must specify at least one of the BundleId and Process parameters. The bundle ID can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyun.security.sase</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The command-line arguments used to start the process. If you specify this parameter, only processes whose command lines contain this content are matched. If you leave this parameter empty, the command line is not verified. The arguments can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--start-minimized</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The directory where the process is located. If you specify this parameter, only processes with the same name in this directory are matched. If you leave this parameter empty, processes in any directory are matched. The directory can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\autotest</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The name of the process. The name can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Everything.exe</para>
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
        public List<UpdateProhibitedSoftwareRequestMacOSProcesses> MacOSProcesses { get; set; }
        public class UpdateProhibitedSoftwareRequestMacOSProcesses : TeaModel {
            /// <summary>
            /// <para>The bundle ID of the application. This parameter is required only for macOS processes. You must specify at least one of the BundleId and Process parameters. The bundle ID can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.autotest.update</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The command-line arguments used to start the process. If you specify this parameter, only processes whose command lines contain this content are matched. If you leave this parameter empty, the command line is not verified. The arguments can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--start-minimized</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The directory where the process is located. If you specify this parameter, only processes with the same name in this directory are matched. If you leave this parameter empty, processes in any directory are matched. The directory can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\autotest</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The name of the process. The name can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Everything.exe</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

        }

        /// <summary>
        /// <para>The name of the prohibited software.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Edge</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the custom prohibited software to update. You can update only custom prohibited software within the current Alibaba Cloud account. Built-in prohibited software cannot be updated. You can obtain the value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListProhibitedSoftware~~">ListProhibitedSoftware</a>: List prohibited software.</description></item>
        /// <item><description><a href="~~CreateProhibitedSoftware~~">CreateProhibitedSoftware</a>: Create custom prohibited software.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swb-a43c9cbf88df****</para>
        /// </summary>
        [NameInMap("SoftwareId")]
        [Validation(Required=false)]
        public string SoftwareId { get; set; }

        /// <summary>
        /// <para>The IDs of the custom prohibited software tags to associate. Duplicate IDs are not allowed.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The list of process configurations for the Windows operating system.</para>
        /// </summary>
        [NameInMap("WindowsProcesses")]
        [Validation(Required=false)]
        public List<UpdateProhibitedSoftwareRequestWindowsProcesses> WindowsProcesses { get; set; }
        public class UpdateProhibitedSoftwareRequestWindowsProcesses : TeaModel {
            /// <summary>
            /// <para>The bundle ID of the application. This parameter is required only for macOS processes. You must specify at least one of the BundleId and Process parameters. The bundle ID can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn.apifox.app</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The command-line arguments used to start the process. If you specify this parameter, only processes whose command lines contain this content are matched. If you leave this parameter empty, the command line is not verified. The arguments can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--start-minimized</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The directory where the process is located. If you specify this parameter, only processes with the same name in this directory are matched. If you leave this parameter empty, processes in any directory are matched. The directory can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\autotest</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The name of the process. The name can be up to 1,024 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Everything.exe</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

        }

    }

}

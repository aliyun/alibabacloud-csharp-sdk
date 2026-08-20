// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The description of the disabled software.</para>
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
        public List<CreateProhibitedSoftwareRequestLinuxProcesses> LinuxProcesses { get; set; }
        public class CreateProhibitedSoftwareRequestLinuxProcesses : TeaModel {
            /// <summary>
            /// <para>The bundle ID of the application. This parameter is required only for macOS processes. You must specify at least one of BundleId and Process. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.autotest.app</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The command line parameters for starting the process. If specified, only processes whose command line contains this content are matched. If left empty, the command line is not checked. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--start-minimized</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The directory where the process is located. If specified, only processes with the same name in this directory are matched. If left empty, processes in any directory are matched. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\\autotest</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The process name. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest.exe</para>
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
        public List<CreateProhibitedSoftwareRequestMacOSProcesses> MacOSProcesses { get; set; }
        public class CreateProhibitedSoftwareRequestMacOSProcesses : TeaModel {
            /// <summary>
            /// <para>The bundle ID of the application. This parameter is required only for macOS processes. You must specify at least one of BundleId and Process. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.autotest.app</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The command line parameters for starting the process. If specified, only processes whose command line contains this content are matched. If left empty, the command line is not checked. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--start-minimized</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The directory where the process is located. If specified, only processes with the same name in this directory are matched. If left empty, processes in any directory are matched. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\\autotest</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The process name. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WeChat</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

        }

        /// <summary>
        /// <para>The name of the disabled software.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thunder</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of custom disabled software tags to associate. Duplicate values are not allowed.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The list of process configurations for the Windows operating system.</para>
        /// </summary>
        [NameInMap("WindowsProcesses")]
        [Validation(Required=false)]
        public List<CreateProhibitedSoftwareRequestWindowsProcesses> WindowsProcesses { get; set; }
        public class CreateProhibitedSoftwareRequestWindowsProcesses : TeaModel {
            /// <summary>
            /// <para>The bundle ID of the application. This parameter is required only for macOS processes. You must specify at least one of BundleId and Process. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.autotest.update</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <para>The command line parameters for starting the process. If specified, only processes whose command line contains this content are matched. If left empty, the command line is not checked. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--start-minimized</para>
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// <para>The directory where the process is located. If specified, only processes with the same name in this directory are matched. If left empty, processes in any directory are matched. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\\autotest</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The process name. Maximum length: 1024 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest.exe</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

        }

    }

}

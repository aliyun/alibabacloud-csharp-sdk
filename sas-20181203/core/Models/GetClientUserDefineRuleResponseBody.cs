// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientUserDefineRuleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the custom defense rule.
        /// </summary>
        [NameInMap("UserDefineRuleDetail")]
        [Validation(Required=false)]
        public GetClientUserDefineRuleResponseBodyUserDefineRuleDetail UserDefineRuleDetail { get; set; }
        public class GetClientUserDefineRuleResponseBodyUserDefineRuleDetail : TeaModel {
            /// <summary>
            /// The action of the custom defense rule. Valid values:
            /// 
            /// *   **0**: allow
            /// *   **1**: block
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// The command line.
            /// </summary>
            [NameInMap("Cmdline")]
            [Validation(Required=false)]
            public string Cmdline { get; set; }

            /// <summary>
            /// The file path.
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// The time when the custom defense rule was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the custom defense rule was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the custom defense rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The hash values of processes.
            /// </summary>
            [NameInMap("Md5List")]
            [Validation(Required=false)]
            public string Md5List { get; set; }

            /// <summary>
            /// The name of the custom defense rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The new file path after the file is renamed.
            /// </summary>
            [NameInMap("NewFilePath")]
            [Validation(Required=false)]
            public string NewFilePath { get; set; }

            /// <summary>
            /// The parent command line.
            /// </summary>
            [NameInMap("ParentCmdline")]
            [Validation(Required=false)]
            public string ParentCmdline { get; set; }

            /// <summary>
            /// The path to the parent process.
            /// </summary>
            [NameInMap("ParentProcPath")]
            [Validation(Required=false)]
            public string ParentProcPath { get; set; }

            /// <summary>
            /// The type of the operating system. Valid values:
            /// 
            /// *   **linux**
            /// *   **windows**
            /// *   **all**
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The port number.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The port number. Valid values: 1 to 65535.
            /// </summary>
            [NameInMap("PortStr")]
            [Validation(Required=false)]
            public string PortStr { get; set; }

            /// <summary>
            /// The path to the process.
            /// </summary>
            [NameInMap("ProcPath")]
            [Validation(Required=false)]
            public string ProcPath { get; set; }

            /// <summary>
            /// The registry value.
            /// </summary>
            [NameInMap("RegistryContent")]
            [Validation(Required=false)]
            public string RegistryContent { get; set; }

            /// <summary>
            /// The registry key.
            /// </summary>
            [NameInMap("RegistryKey")]
            [Validation(Required=false)]
            public string RegistryKey { get; set; }

            /// <summary>
            /// The type of the custom defense rule. Valid values:
            /// 
            /// *   **1**: Process hash
            /// *   **2**: Command line
            /// *   **3**: Process Network
            /// *   **4**: File Read and Write
            /// *   **5**: Operation on Registry
            /// *   **6**: Dynamic-link Library Loading
            /// *   **7**: File Renaming
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}

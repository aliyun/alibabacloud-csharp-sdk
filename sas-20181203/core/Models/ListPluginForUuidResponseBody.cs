// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPluginForUuidResponseBody : TeaModel {
        /// <summary>
        /// The type of the plug-in. Valid values:
        /// 
        /// *   **auto_breaking**: antivirus
        /// *   **ransomware_breaking**: anti-ransomware (bait capture)
        /// *   **webshell_cloud_breaking**: webshell prevention
        /// *   **alisecguard**: client protection
        /// *   **alinet**: malicious behavior defense
        /// </summary>
        [NameInMap("AegisUuidTargetPluginConfigList")]
        [Validation(Required=false)]
        public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList> AegisUuidTargetPluginConfigList { get; set; }
        public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList : TeaModel {
            /// <summary>
            /// The information about the plug-in.
            /// </summary>
            [NameInMap("AegisSuspiciousConfigList")]
            [Validation(Required=false)]
            public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList> AegisSuspiciousConfigList { get; set; }
            public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList : TeaModel {
                /// <summary>
                /// The name of the plug-in. Valid values:
                /// 
                /// *   **alihips**: trojan-specific prevention
                /// *   **alisecguard**: attack-specific prevention
                /// *   **alinet**: defense against attacks on servers
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public bool? Config { get; set; }

                /// <summary>
                /// Queries the information about plug-ins on a server.
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// ListPluginForUuid
                /// </summary>
                [NameInMap("OverallConfig")]
                [Validation(Required=false)]
                public bool? OverallConfig { get; set; }

                /// <summary>
                /// The ID of the request, which is used to locate and troubleshoot issues.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The installation code of the plug-in.
            /// </summary>
            [NameInMap("PluginInstallCode")]
            [Validation(Required=false)]
            public string PluginInstallCode { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// 
            /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// The version of the plug-in.
            /// </summary>
            [NameInMap("PluginOnlineInstalled")]
            [Validation(Required=false)]
            public bool? PluginOnlineInstalled { get; set; }

            /// <summary>
            /// An array that consists of the configurations of plug-ins.
            /// </summary>
            [NameInMap("PluginOnlineStatus")]
            [Validation(Required=false)]
            public bool? PluginOnlineStatus { get; set; }

            /// <summary>
            /// Indicates whether the plug-in is enabled. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

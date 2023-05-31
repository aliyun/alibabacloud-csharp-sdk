// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPluginForUuidResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the plug-ins.
        /// </summary>
        [NameInMap("AegisUuidTargetPluginConfigList")]
        [Validation(Required=false)]
        public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList> AegisUuidTargetPluginConfigList { get; set; }
        public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList : TeaModel {
            /// <summary>
            /// An array that consists of the configurations of plug-ins.
            /// </summary>
            [NameInMap("AegisSuspiciousConfigList")]
            [Validation(Required=false)]
            public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList> AegisSuspiciousConfigList { get; set; }
            public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList : TeaModel {
                /// <summary>
                /// Indicates whether the plug-in is enabled. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public bool? Config { get; set; }

                /// <summary>
                /// The message that indicates whether you are authorized to install the plug-in on your server or whether the plug-in is installed on your server. Valid values:
                /// 
                /// *   **authorized**: authorized
                /// *   **unauthorized**: unauthorized
                /// *   **unbind**: not installed
                /// *   **nonsupport**: not supported
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// Indicates whether the plug-in is globally configured. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("OverallConfig")]
                [Validation(Required=false)]
                public bool? OverallConfig { get; set; }

                /// <summary>
                /// The name of the plug-in. Valid values:
                /// 
                /// *   **alihips**: trojan-specific prevention
                /// *   **alisecguard**: attack-specific prevention
                /// *   **alinet**: defense against attacks on servers
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
            /// The name of the plug-in. Valid values:
            /// 
            /// *   **alihips**: trojan-specific prevention
            /// *   **alisecguard**: attack-specific prevention
            /// *   **alinet**: defense against attacks on servers
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// Indicates whether the plug-in is installed. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("PluginOnlineInstalled")]
            [Validation(Required=false)]
            public bool? PluginOnlineInstalled { get; set; }

            /// <summary>
            /// Indicates whether the plug-in is online. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("PluginOnlineStatus")]
            [Validation(Required=false)]
            public bool? PluginOnlineStatus { get; set; }

            /// <summary>
            /// The version of the plug-in.
            /// </summary>
            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

        }

        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

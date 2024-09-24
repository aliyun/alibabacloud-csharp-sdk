// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPluginForUuidResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about the plug-ins.</para>
        /// </summary>
        [NameInMap("AegisUuidTargetPluginConfigList")]
        [Validation(Required=false)]
        public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList> AegisUuidTargetPluginConfigList { get; set; }
        public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList : TeaModel {
            /// <summary>
            /// <para>An array that consists of the configurations of plug-ins.</para>
            /// </summary>
            [NameInMap("AegisSuspiciousConfigList")]
            [Validation(Required=false)]
            public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList> AegisSuspiciousConfigList { get; set; }
            public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the plug-in is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public bool? Config { get; set; }

                /// <summary>
                /// <para>The message that indicates whether you are authorized to install the plug-in on your server or whether the plug-in is installed on your server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>authorized</b>: authorized</description></item>
                /// <item><description><b>unauthorized</b>: unauthorized</description></item>
                /// <item><description><b>unbind</b>: not installed</description></item>
                /// <item><description><b>nonsupport</b>: not supported</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>authorized</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>Indicates whether the plug-in is globally configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: yes</description></item>
                /// <item><description><b>false</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OverallConfig")]
                [Validation(Required=false)]
                public bool? OverallConfig { get; set; }

                /// <summary>
                /// <para>The name of the plug-in. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>alihips</b>: trojan-specific prevention</description></item>
                /// <item><description><b>alisecguard</b>: attack-specific prevention</description></item>
                /// <item><description><b>alinet</b>: defense against attacks on servers</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alisecguard</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The installation code of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k5O5nd</para>
            /// </summary>
            [NameInMap("PluginInstallCode")]
            [Validation(Required=false)]
            public string PluginInstallCode { get; set; }

            /// <summary>
            /// <para>The name of the plug-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>alihips</b>: trojan-specific prevention</description></item>
            /// <item><description><b>alisecguard</b>: attack-specific prevention</description></item>
            /// <item><description><b>alinet</b>: defense against attacks on servers</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alisecguard</para>
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// <para>Indicates whether the plug-in is installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PluginOnlineInstalled")]
            [Validation(Required=false)]
            public bool? PluginOnlineInstalled { get; set; }

            /// <summary>
            /// <para>Indicates whether the plug-in is online. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PluginOnlineStatus")]
            [Validation(Required=false)]
            public bool? PluginOnlineStatus { get; set; }

            /// <summary>
            /// <para>The version of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00_10</para>
            /// </summary>
            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

        }

        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPluginForUuidResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of plugin information.</para>
        /// </summary>
        [NameInMap("AegisUuidTargetPluginConfigList")]
        [Validation(Required=false)]
        public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList> AegisUuidTargetPluginConfigList { get; set; }
        public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigList : TeaModel {
            /// <summary>
            /// <para>The list of plugin configuration information.</para>
            /// </summary>
            [NameInMap("AegisSuspiciousConfigList")]
            [Validation(Required=false)]
            public List<ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList> AegisSuspiciousConfigList { get; set; }
            public class ListPluginForUuidResponseBodyAegisUuidTargetPluginConfigListAegisSuspiciousConfigList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the plugin is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: enabled</description></item>
                /// <item><description><b>false</b>: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public bool? Config { get; set; }

                /// <summary>
                /// <para>The authorization binding information of the plugin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>authorized</b>: authorized</description></item>
                /// <item><description><b>unauthorized</b>: unauthorized</description></item>
                /// <item><description><b>unbind</b>: unbound</description></item>
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
                /// <para>Indicates whether this is a global configuration. Valid values:</para>
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
                /// <para>The name of the plugin type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>alihips</b>: performs virus and trojan protection</description></item>
                /// <item><description><b>alisecguard</b>: performs attack protection</description></item>
                /// <item><description><b>alinet</b>: protects against network-side attacks on the server</description></item>
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
            /// <para>The installation code of the plugin instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k5O5nd</para>
            /// </summary>
            [NameInMap("PluginInstallCode")]
            [Validation(Required=false)]
            public string PluginInstallCode { get; set; }

            /// <summary>
            /// <para>The name of the plugin type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>alihips</b>: performs virus and trojan protection</description></item>
            /// <item><description><b>alisecguard</b>: performs attack protection</description></item>
            /// <item><description><b>alinet</b>: protects against network-side attacks on the server</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alisecguard</para>
            /// </summary>
            [NameInMap("PluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            /// <summary>
            /// <para>Indicates whether the plugin is installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: installed</description></item>
            /// <item><description><b>false</b>: not installed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PluginOnlineInstalled")]
            [Validation(Required=false)]
            public bool? PluginOnlineInstalled { get; set; }

            /// <summary>
            /// <para>Indicates whether the plugin is online. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: online</description></item>
            /// <item><description><b>false</b>: offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PluginOnlineStatus")]
            [Validation(Required=false)]
            public bool? PluginOnlineStatus { get; set; }

            /// <summary>
            /// <para>The plugin version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00_10</para>
            /// </summary>
            [NameInMap("PluginVersion")]
            [Validation(Required=false)]
            public string PluginVersion { get; set; }

        }

        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The detailed information of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request. It can be used for troubleshooting and problem locating.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

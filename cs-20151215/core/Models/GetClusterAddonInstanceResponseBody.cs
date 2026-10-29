// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom parameter settings of the add-on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sls_project_name&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The log feature status of the add-on.</para>
        /// </summary>
        [NameInMap("logging")]
        [Validation(Required=false)]
        public GetClusterAddonInstanceResponseBodyLogging Logging { get; set; }
        public class GetClusterAddonInstanceResponseBodyLogging : TeaModel {
            /// <summary>
            /// <para>Specifies whether the add-on supports the log feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Supported.</para>
            /// </description></item>
            /// <item><description><para>false: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("capable")]
            [Validation(Required=false)]
            public bool? Capable { get; set; }

            /// <summary>
            /// <para>Specifies whether the log feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The Log Service project used by the add-on log feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-c02b3e03be10643e8a644a843ffcb****</para>
            /// </summary>
            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// <para>The Logstore used by the add-on log feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

        }

        /// <summary>
        /// <para>The name of the add-on instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-node-problem-detector</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The state of the add-on. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: Installed.</description></item>
        /// <item><description>updating: Updating.</description></item>
        /// <item><description>upgrading: Upgrading.</description></item>
        /// <item><description>deleting: Uninstalling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The version of the add-on instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.16</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

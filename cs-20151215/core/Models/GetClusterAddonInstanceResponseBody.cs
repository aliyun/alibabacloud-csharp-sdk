// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom parameter settings of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sls_project_name&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The logging feature status of the component.</para>
        /// </summary>
        [NameInMap("logging")]
        [Validation(Required=false)]
        public GetClusterAddonInstanceResponseBodyLogging Logging { get; set; }
        public class GetClusterAddonInstanceResponseBodyLogging : TeaModel {
            /// <summary>
            /// <para>Indicates whether the component supports the logging feature.</para>
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
            /// <para>Indicates whether the logging feature is enabled for the component.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Not enabled.</para>
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
            /// <para>The Log Service project used by the logging feature of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-c02b3e03be10643e8a644a843ffcb****</para>
            /// </summary>
            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// <para>The Log Service Logstore used by the logging feature of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

        }

        /// <summary>
        /// <para>The component instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-node-problem-detector</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The component status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: installed.</description></item>
        /// <item><description>updating: being modified.</description></item>
        /// <item><description>upgrading: being upgraded.</description></item>
        /// <item><description>deleting: being uninstalled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The component instance version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.16</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom configurations of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sls_project_name&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The status of Simple Log Service.</para>
        /// </summary>
        [NameInMap("logging")]
        [Validation(Required=false)]
        public GetClusterAddonInstanceResponseBodyLogging Logging { get; set; }
        public class GetClusterAddonInstanceResponseBodyLogging : TeaModel {
            /// <summary>
            /// <para>Indicates whether Simple Log Service is supported by the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("capable")]
            [Validation(Required=false)]
            public bool? Capable { get; set; }

            /// <summary>
            /// <para>Indicates whether Simple Log Service is enabled for the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project that is used to collect logs for the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-log-project</para>
            /// </summary>
            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore that is used to collect logs for the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

        }

        /// <summary>
        /// <para>The name of the component instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-node-problem-detector</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: The component is installed.</description></item>
        /// <item><description>updating: The component is being modified.</description></item>
        /// <item><description>upgrading: The component is being updated.</description></item>
        /// <item><description>deleting: The component is being uninstalled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The version of the component instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.16</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

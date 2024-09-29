// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>Status Code. Description 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvironmentFeaturesResponseBodyData> Data { get; set; }
        public class ListEnvironmentFeaturesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alias of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus Agent</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The feature configuration.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public Dictionary<string, string> Config { get; set; }

            /// <summary>
            /// <para>The description of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collect Metric data using the Prometheus collection specification.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the environment instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-xxxxx</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The URL of the icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx">http://xxx</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh: Chinese</description></item>
            /// <item><description>en: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The latest version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.17</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the component is fully managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>metric-agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Installing: The agent is being installed.</description></item>
            /// <item><description>Success: The agent is installed.</description></item>
            /// <item><description>Failed: The agent failed to be installed.</description></item>
            /// <item><description>UnInstall: The agent is uninstalled.</description></item>
            /// <item><description>Uninstalling: The agent is being uninstalled.</description></item>
            /// <item><description>UnInstallFailed: The agent failed to be uninstalled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.17</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>40B10E04-81E8-4643-970D-F1B38F2E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the alert rule was deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The alert rule was deleted.</description></item>
        /// <item><description><c>false</c>: The alert rule failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

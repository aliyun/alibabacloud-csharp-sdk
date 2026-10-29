// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available components.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>The CPU architectures supported by the component.</para>
            /// </summary>
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public List<string> Architecture { get; set; }

            /// <summary>
            /// <para>The category of the component. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>core: core component</description></item>
            /// <item><description>network: network component</description></item>
            /// <item><description>security: security component</description></item>
            /// <item><description>storage: storage component</description></item>
            /// <item><description>monitor: logging and monitoring component</description></item>
            /// <item><description>application: application component</description></item>
            /// </list>
            /// <para>An empty value indicates that the component belongs to another category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>monitor</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The schema of custom parameters for the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("config_schema")]
            [Validation(Required=false)]
            public string ConfigSchema { get; set; }

            /// <summary>
            /// <para>Indicates whether the component is installed by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The component is installed by default when the cluster is created.</description></item>
            /// <item><description>false: The component is not installed by default.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("install_by_default")]
            [Validation(Required=false)]
            public bool? InstallByDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the component is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The component is managed.</description></item>
            /// <item><description>false: The component is not managed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// <para>The name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prometheus</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operations supported by the component.</para>
            /// </summary>
            [NameInMap("supported_actions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            /// <summary>
            /// <para>The version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.9</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

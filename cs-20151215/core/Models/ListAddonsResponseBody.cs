// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of available add-ons.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>The CPU architectures supported by the add-on.</para>
            /// </summary>
            [NameInMap("architecture")]
            [Validation(Required=false)]
            public List<string> Architecture { get; set; }

            /// <summary>
            /// <para>The category of the add-on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>core: Core add-on.</description></item>
            /// <item><description>network: Network add-on.</description></item>
            /// <item><description>security: Security add-on.</description></item>
            /// <item><description>storage: Storage add-on.</description></item>
            /// <item><description>monitor: Logging and monitoring add-on.</description></item>
            /// <item><description>application: Application add-on.
            /// An empty value indicates that the add-on type is other.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>monitor</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The schema of custom parameters for the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("config_schema")]
            [Validation(Required=false)]
            public string ConfigSchema { get; set; }

            /// <summary>
            /// <para>Indicates whether the add-on is installed by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The add-on is installed by default when the cluster is created.</description></item>
            /// <item><description>false: The add-on is not installed by default.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("install_by_default")]
            [Validation(Required=false)]
            public bool? InstallByDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the add-on is managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The add-on is managed.</description></item>
            /// <item><description>false: The add-on is not managed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// <para>The name of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prometheus</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operations supported by the add-on.</para>
            /// </summary>
            [NameInMap("supported_actions")]
            [Validation(Required=false)]
            public List<string> SupportedActions { get; set; }

            /// <summary>
            /// <para>The version of the add-on.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonResponseBody : TeaModel {
        /// <summary>
        /// <para>CPU architectures supported by the component.</para>
        /// </summary>
        [NameInMap("architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

        /// <summary>
        /// <para>Component category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>network</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Custom parameter schema of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("config_schema")]
        [Validation(Required=false)]
        public string ConfigSchema { get; set; }

        /// <summary>
        /// <para>Whether it is installed by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("install_by_default")]
        [Validation(Required=false)]
        public bool? InstallByDefault { get; set; }

        /// <summary>
        /// <para>Whether it is a managed component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("managed")]
        [Validation(Required=false)]
        public bool? Managed { get; set; }

        /// <summary>
        /// <para>Component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coredns</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Information about the latest component versions.</para>
        /// </summary>
        [NameInMap("newer_versions")]
        [Validation(Required=false)]
        public List<DescribeAddonResponseBodyNewerVersions> NewerVersions { get; set; }
        public class DescribeAddonResponseBodyNewerVersions : TeaModel {
            /// <summary>
            /// <para>The minimum cluster version required by this component version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.20.4</para>
            /// </summary>
            [NameInMap("minimum_cluster_version")]
            [Validation(Required=false)]
            public string MinimumClusterVersion { get; set; }

            /// <summary>
            /// <para>Whether the component can be upgraded to this version.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Upgrade is supported.</para>
            /// </description></item>
            /// <item><description><para>false: Upgrade is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("upgradable")]
            [Validation(Required=false)]
            public bool? Upgradable { get; set; }

            /// <summary>
            /// <para>The latest version number of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.9.3.10-7dfca203-aliyun</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Operations supported by the component.</para>
        /// </summary>
        [NameInMap("supported_actions")]
        [Validation(Required=false)]
        public List<string> SupportedActions { get; set; }

        /// <summary>
        /// <para>Component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.9.3.6-32932850-aliyun</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonResponseBody : TeaModel {
        /// <summary>
        /// Architectures supported by the component. Valid values:
        /// 
        /// *   amd64
        /// *   arm64
        /// </summary>
        [NameInMap("architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

        /// <summary>
        /// The category of the component.
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The custom parameter schema of the component.
        /// </summary>
        [NameInMap("config_schema")]
        [Validation(Required=false)]
        public string ConfigSchema { get; set; }

        /// <summary>
        /// Indicates whether the component is automatically installed by default.
        /// </summary>
        [NameInMap("install_by_default")]
        [Validation(Required=false)]
        public bool? InstallByDefault { get; set; }

        /// <summary>
        /// Indicates whether the component is fully managed.
        /// </summary>
        [NameInMap("managed")]
        [Validation(Required=false)]
        public bool? Managed { get; set; }

        /// <summary>
        /// The name of the component.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The latest version of the component.
        /// </summary>
        [NameInMap("newer_versions")]
        [Validation(Required=false)]
        public List<DescribeAddonResponseBodyNewerVersions> NewerVersions { get; set; }
        public class DescribeAddonResponseBodyNewerVersions : TeaModel {
            /// <summary>
            /// The minimum cluster version required by the component version.
            /// </summary>
            [NameInMap("minimum_cluster_version")]
            [Validation(Required=false)]
            public string MinimumClusterVersion { get; set; }

            /// <summary>
            /// Indicates whether the component can be updated to the version.
            /// </summary>
            [NameInMap("upgradable")]
            [Validation(Required=false)]
            public bool? Upgradable { get; set; }

            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// Operations supported by the component. Valid values:
        /// 
        /// *   Install
        /// *   Upgrade
        /// *   Modify
        /// *   Uninstall
        /// </summary>
        [NameInMap("supported_actions")]
        [Validation(Required=false)]
        public List<string> SupportedActions { get; set; }

        /// <summary>
        /// The version of the component.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

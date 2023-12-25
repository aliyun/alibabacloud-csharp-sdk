// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAddonResponseBody : TeaModel {
        [NameInMap("architecture")]
        [Validation(Required=false)]
        public List<string> Architecture { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("config_schema")]
        [Validation(Required=false)]
        public string ConfigSchema { get; set; }

        [NameInMap("install_by_default")]
        [Validation(Required=false)]
        public bool? InstallByDefault { get; set; }

        [NameInMap("managed")]
        [Validation(Required=false)]
        public bool? Managed { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("newer_versions")]
        [Validation(Required=false)]
        public List<DescribeAddonResponseBodyNewerVersions> NewerVersions { get; set; }
        public class DescribeAddonResponseBodyNewerVersions : TeaModel {
            [NameInMap("minimum_cluster_version")]
            [Validation(Required=false)]
            public string MinimumClusterVersion { get; set; }

            [NameInMap("upgradable")]
            [Validation(Required=false)]
            public bool? Upgradable { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("supported_actions")]
        [Validation(Required=false)]
        public List<string> SupportedActions { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}

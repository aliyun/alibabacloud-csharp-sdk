// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateAliasRequest : TeaModel {
        /// <summary>
        /// The canary release version to which the alias points and the weight of the canary release version.
        /// 
        /// *   The canary release version takes effect only when the function is invoked.
        /// *   The value consists of a version number and a specific weight. For example, 2:0.05 indicates that when a function is invoked, Version 2 is the canary release version, 5% of the traffic is distributed to the canary release version, and 95% of the traffic is distributed to the major version.
        /// </summary>
        [NameInMap("additionalVersionWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> AdditionalVersionWeight { get; set; }

        /// <summary>
        /// The name of the alias. The name can contain letters, digits, underscores (\_), and hyphens (-) only. The name cannot start with a digit or a hyphen (-). The name must be 1 to 128 characters in length. The name cannot be set to **LATEST**
        /// </summary>
        [NameInMap("aliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The description of the alias.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The canary release mode. Default values: off. Valid values:
        /// 
        /// *   **Random**: random canary release.
        /// *   **Content**: rule-based canary release. By default, this parameter is empty.
        /// </summary>
        [NameInMap("resolvePolicy")]
        [Validation(Required=false)]
        public string ResolvePolicy { get; set; }

        /// <summary>
        /// The canary release rule. Traffic that meets the canary release rule is routed to the canary release instance.
        /// </summary>
        [NameInMap("routePolicy")]
        [Validation(Required=false)]
        public RoutePolicy RoutePolicy { get; set; }

        /// <summary>
        /// The ID of the version to which the alias points.
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}

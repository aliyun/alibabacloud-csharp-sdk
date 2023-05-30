// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UpdateAliasRequest : TeaModel {
        /// <summary>
        /// The additional version to which the alias points and the weight of the additional version.
        /// 
        /// *   The additional version takes effect only when the function is invoked.
        /// *   The value consists of a version number and a specific weight. For example, 2:0.05 indicates that when a function is invoked, Version 2 is the canary release version, 5% of the traffic is distributed to the canary release version, and 95% of the traffic is distributed to the major version.
        /// </summary>
        [NameInMap("additionalVersionWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> AdditionalVersionWeight { get; set; }

        /// <summary>
        /// The description of the alias.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The canary release mode. Valid values:
        /// 
        /// *   **Random**: random canary release. This is the default value.
        /// *   **Content**: rule-based canary release.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetAliasResponseBody : TeaModel {
        /// <summary>
        /// The canary release version to which the alias points and the weight of the canary release version. 
        /// 
        /// - The canary release version takes effect only when the function is invoked. 
        /// - The value consists of a version number and the corresponding weight. For example, 2:0.05 indicates that when a function is invoked, Version 2 is the canary release version, 5% of the traffic is distributed to the canary release version, and 95% of the traffic is distributed to the major version.
        /// </summary>
        [NameInMap("additionalVersionWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> AdditionalVersionWeight { get; set; }

        /// <summary>
        /// The name of the alias.
        /// </summary>
        [NameInMap("aliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The time when the alias was created.
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The description of the alias.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the alias was last modified.
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// The canary release mode. Valid values:
        /// 
        /// - **Random**: random canary release. This is the default value.
        /// - **Content**: rule-based canary release.
        /// </summary>
        [NameInMap("resolvePolicy")]
        [Validation(Required=false)]
        public string ResolvePolicy { get; set; }

        /// <summary>
        /// Canary release rule. The traffic that meets the conditions of the canary release rule is diverted to the canary release instances.
        /// </summary>
        [NameInMap("routePolicy")]
        [Validation(Required=false)]
        public RoutePolicy RoutePolicy { get; set; }

        /// <summary>
        /// The version to which the alias points.
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}

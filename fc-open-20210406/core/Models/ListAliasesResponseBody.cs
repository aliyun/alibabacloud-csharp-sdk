// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListAliasesResponseBody : TeaModel {
        /// <summary>
        /// The list of aliases.
        /// </summary>
        [NameInMap("aliases")]
        [Validation(Required=false)]
        public List<ListAliasesResponseBodyAliases> Aliases { get; set; }
        public class ListAliasesResponseBodyAliases : TeaModel {
            /// <summary>
            /// The weight of the canary release version.
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
            /// The creation time.
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
            /// The last update time.
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            [NameInMap("resolvePolicy")]
            [Validation(Required=false)]
            public string ResolvePolicy { get; set; }

            [NameInMap("routePolicy")]
            [Validation(Required=false)]
            public RoutePolicy RoutePolicy { get; set; }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// The token used to obtain more results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

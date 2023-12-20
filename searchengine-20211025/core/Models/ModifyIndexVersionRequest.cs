// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexVersionRequest : TeaModel {
        /// <summary>
        /// The keyword used to search for a version. Fuzzy match is supported.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ModifyIndexVersionRequestBody> Body { get; set; }
        public class ModifyIndexVersionRequestBody : TeaModel {
            /// <summary>
            /// The ID of the index deployed in offline mode.
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public string BuildDeployId { get; set; }

            /// <summary>
            /// The name of the index.
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// The version of the index.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

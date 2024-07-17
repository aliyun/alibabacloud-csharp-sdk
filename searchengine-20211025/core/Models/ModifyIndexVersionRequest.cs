// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexVersionRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ModifyIndexVersionRequestBody> Body { get; set; }
        public class ModifyIndexVersionRequestBody : TeaModel {
            /// <summary>
            /// The deployment ID of the data source.
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public string BuildDeployId { get; set; }

            /// <summary>
            /// The index name.
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// The index version.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

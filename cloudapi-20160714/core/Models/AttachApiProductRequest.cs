// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AttachApiProductRequest : TeaModel {
        /// <summary>
        /// The ID of the API product.
        /// </summary>
        [NameInMap("ApiProductId")]
        [Validation(Required=false)]
        public string ApiProductId { get; set; }

        /// <summary>
        /// The APIs to be attached.
        /// </summary>
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public List<AttachApiProductRequestApis> Apis { get; set; }
        public class AttachApiProductRequestApis : TeaModel {
            /// <summary>
            /// The API ID.
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// The environment. Valid values:
            /// 
            /// *   **RELEASE**: the production environment
            /// *   **PRE**: the staging environment
            /// *   **TEST**: the test environment
            /// </summary>
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

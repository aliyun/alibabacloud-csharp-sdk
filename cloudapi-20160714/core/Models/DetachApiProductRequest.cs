// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DetachApiProductRequest : TeaModel {
        /// <summary>
        /// The ID of the API product.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiProductId")]
        [Validation(Required=false)]
        public string ApiProductId { get; set; }

        /// <summary>
        /// The APIs that you want to detach from the API product.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public List<DetachApiProductRequestApis> Apis { get; set; }
        public class DetachApiProductRequestApis : TeaModel {
            /// <summary>
            /// The API ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// The environment to which the API is published. Valid values:
            /// 
            /// *   **RELEASE**: the production environment
            /// *   **PRE**: the pre-release environment
            /// *   **TEST**: the test environment
            /// 
            /// This parameter is required.
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

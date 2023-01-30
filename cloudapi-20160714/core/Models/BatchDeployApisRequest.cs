// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchDeployApisRequest : TeaModel {
        /// <summary>
        /// The APIs that you want to operate.
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public List<BatchDeployApisRequestApi> Api { get; set; }
        public class BatchDeployApisRequestApi : TeaModel {
            /// <summary>
            /// The ID of the API.
            /// </summary>
            [NameInMap("ApiUid")]
            [Validation(Required=false)]
            public string ApiUid { get; set; }

            /// <summary>
            /// The ID of the API group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The name of the runtime environment. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **TEST**
        /// *   PRE: the pre-release environment
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}

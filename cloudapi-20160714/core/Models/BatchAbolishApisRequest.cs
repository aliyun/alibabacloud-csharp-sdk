// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class BatchAbolishApisRequest : TeaModel {
        /// <summary>
        /// The APIs that you want to operate.
        /// </summary>
        [NameInMap("Api")]
        [Validation(Required=false)]
        public List<BatchAbolishApisRequestApi> Api { get; set; }
        public class BatchAbolishApisRequestApi : TeaModel {
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

            /// <summary>
            /// The ID of the environment.
            /// </summary>
            [NameInMap("StageId")]
            [Validation(Required=false)]
            public string StageId { get; set; }

            /// <summary>
            /// The name of the environment.
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

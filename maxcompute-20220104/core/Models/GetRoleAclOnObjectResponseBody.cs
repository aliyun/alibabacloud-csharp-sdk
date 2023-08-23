// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRoleAclOnObjectResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRoleAclOnObjectResponseBodyData Data { get; set; }
        public class GetRoleAclOnObjectResponseBodyData : TeaModel {
            /// <summary>
            /// The operations that were performed on the object.
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

            /// <summary>
            /// The name of the object.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

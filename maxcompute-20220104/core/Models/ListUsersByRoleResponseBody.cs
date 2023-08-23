// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListUsersByRoleResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListUsersByRoleResponseBodyData Data { get; set; }
        public class ListUsersByRoleResponseBodyData : TeaModel {
            /// <summary>
            /// The users.
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListUsersByRoleResponseBodyDataUsers> Users { get; set; }
            public class ListUsersByRoleResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// The name of the user.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

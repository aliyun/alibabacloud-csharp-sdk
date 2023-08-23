// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectUsersResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectUsersResponseBodyData Data { get; set; }
        public class ListProjectUsersResponseBodyData : TeaModel {
            /// <summary>
            /// An array that contains users.
            /// </summary>
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<ListProjectUsersResponseBodyDataUsers> Users { get; set; }
            public class ListProjectUsersResponseBodyDataUsers : TeaModel {
                /// <summary>
                /// The name of the user.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

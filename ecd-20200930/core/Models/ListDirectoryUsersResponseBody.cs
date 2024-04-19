// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListDirectoryUsersResponseBody : TeaModel {
        /// <summary>
        /// The token used to start the next query. If the value of this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The names of users corresponding to the AD directory. If the AD directory contains only Administrator and Guest, an empty Users array is returned.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListDirectoryUsersResponseBodyUsers> Users { get; set; }
        public class ListDirectoryUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// The display name of the user.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The name of the user.
            /// </summary>
            [NameInMap("EndUser")]
            [Validation(Required=false)]
            public string EndUser { get; set; }

        }

    }

}

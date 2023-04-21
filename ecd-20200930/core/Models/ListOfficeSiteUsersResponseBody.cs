// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteUsersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The usernames of AD users.
        /// 
        /// This parameter is empty if the AD users include only Administrator and Guest.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The usernames of AD users.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListOfficeSiteUsersResponseBodyUsers> Users { get; set; }
        public class ListOfficeSiteUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// The display name of the AD user.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The username of the AD user.
            /// </summary>
            [NameInMap("EndUser")]
            [Validation(Required=false)]
            public string EndUser { get; set; }

        }

    }

}

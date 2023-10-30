// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RemoveUsersFromGroupResponseBody : TeaModel {
        /// <summary>
        /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~315526~~).
        /// 
        /// For more information about sample requests, see the "Examples" section of this topic.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Removes one or more users from a user group.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RemoveUsersFromGroupResponseBodyResults> Results { get; set; }
        public class RemoveUsersFromGroupResponseBodyResults : TeaModel {
            /// <summary>
            /// RemoveUsersFromGroup
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// WB01014029
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// RemoveUsersFromGroup
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

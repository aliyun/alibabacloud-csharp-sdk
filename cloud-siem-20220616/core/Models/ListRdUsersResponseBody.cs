// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListRdUsersResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRdUsersResponseBodyData> Data { get; set; }
        public class ListRdUsersResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the account can be used to view the logs and alerts within the account.
            /// </summary>
            [NameInMap("DelegatedOrNot")]
            [Validation(Required=false)]
            public bool? DelegatedOrNot { get; set; }

            /// <summary>
            /// Indicates whether the account is added to the threat analysis feature for centralized management. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Joined")]
            [Validation(Required=false)]
            public bool? Joined { get; set; }

            /// <summary>
            /// The time when the account was added to the threat analysis feature.
            /// </summary>
            [NameInMap("JoinedTime")]
            [Validation(Required=false)]
            public string JoinedTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to perform operations supported by the threat analysis feature.
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// The username of the Alibaba Cloud account that can be used to perform operations supported by the threat analysis feature.
            /// </summary>
            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

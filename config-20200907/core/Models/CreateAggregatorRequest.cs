// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregatorRequest : TeaModel {
        /// <summary>
        /// The type of the member account. Valid value: ResourceDirectory.
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public List<CreateAggregatorRequestAggregatorAccounts> AggregatorAccounts { get; set; }
        public class CreateAggregatorRequestAggregatorAccounts : TeaModel {
            /// <summary>
            /// The Alibaba Cloud account ID of the member. For more information about how to obtain the ID of a member account, see [ListAccounts](~~160016~~).
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The name of the member account. For more information about how to obtain the name of a member account, see [ListAccounts](~~160016~~).
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The type of the member account. The value is fixed to ResourceDirectory.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

        /// <summary>
        /// The name of the account group.
        /// </summary>
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// The type of the account group. Valid values:
        /// 
        /// *   RD: global account group
        /// *   CUSTOM (default): custom account group
        /// </summary>
        [NameInMap("AggregatorType")]
        [Validation(Required=false)]
        public string AggregatorType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The `token` can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the account group.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

    }

}

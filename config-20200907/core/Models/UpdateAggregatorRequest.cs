// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregatorRequest : TeaModel {
        /// <summary>
        /// The information about the member accounts in the account group.
        /// 
        /// >  When you modify the configurations of an account group, this parameter can be left empty. In this case, the member account list is not updated. If you want to update the member account list, you must set the `AccountId`, `AccountName` and `AccountType` parameters.
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public List<UpdateAggregatorRequestAggregatorAccounts> AggregatorAccounts { get; set; }
        public class UpdateAggregatorRequestAggregatorAccounts : TeaModel {
            /// <summary>
            /// The member account ID, which indicates the Alibaba Cloud account ID of the member account.
            /// 
            /// For more information about how to obtain the ID of a member account, see [ListAccounts](~~160016~~).
            /// 
            /// >  If you want to update the member account list, you must set the `AccountId`, `AccountName` and `AccountType` parameters.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The member account name, which indicates the name of the Alibaba Cloud account that corresponds to the member account.
            /// 
            /// For more information about how to obtain the name of a member account, see [ListAccounts](~~160016~~).
            /// 
            /// >  If you want to update the member account list, you must set the `AccountId`, `AccountName` and `AccountType` parameters.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The affiliation of the member account. You can set this parameter to only ResourceDirectory.
            /// 
            /// >  If you want to update the member account list, you must set the `AccountId`, `AccountName` and `AccountType` parameters.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The name of the account group.
        /// 
        /// For more information about how to obtain the name of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the account group.
        /// 
        /// For more information about how to obtain the description of an account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}

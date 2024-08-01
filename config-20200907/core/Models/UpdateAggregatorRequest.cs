// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregatorRequest : TeaModel {
        /// <summary>
        /// The members in the account group.
        /// 
        /// >  When you modify the configurations of an account group, this parameter can be left empty. In this case, the member list is not updated. If you want to update the member list, you must configure both the `AccountId` and `AccountType` parameters.
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public List<UpdateAggregatorRequestAggregatorAccounts> AggregatorAccounts { get; set; }
        public class UpdateAggregatorRequestAggregatorAccounts : TeaModel {
            /// <summary>
            /// The ID of the member.
            /// 
            /// For more information about how to obtain the ID of a member, see [ListAccounts](https://help.aliyun.com/document_detail/160016.html).
            /// 
            /// >  If you want to update the member list, you must configure both the `AccountId` and `AccountType` parameters.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The display name of the member.
            /// 
            /// For more information about how to obtain the name of a member, see [ListAccounts](https://help.aliyun.com/document_detail/160016.html).
            /// 
            /// >  If you want to update the member list, you must configure both the `AccountId` and `AccountType` parameters.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The resource directory to which the member belongs. Valid value: ResourceDirectory. ResourceDirectory indicates that the member belongs to a resource directory.
            /// 
            /// >  If you want to update the member list, you must configure both the `AccountId` and `AccountType` parameters.
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of an account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The name of the account group.
        /// 
        /// For more information about how to obtain the name of an account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
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
        /// For more information about how to obtain the description of an account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}

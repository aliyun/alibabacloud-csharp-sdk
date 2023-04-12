// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregatorShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the member accounts in the account group. Example:
        /// 
        /// ```
        /// 
        /// [{
        /// 	"accountId": 171322098523****,
        /// 	"accountType":"ResourceDirectory",
        ///                 "accountName":"Alice"
        /// }, {
        /// 	"accountId": 100532098349****,
        /// 	"accountType":"ResourceDirectory",
        ///                 "accountName":"Tom"
        /// }]
        /// ```
        /// 
        /// >  If the `AggregatorType` parameter is set to `RD`, this parameter can be left empty because all accounts in the resource directory are automatically added to the global account group.
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public string AggregatorAccountsShrink { get; set; }

        /// <summary>
        /// The name of the account group.
        /// </summary>
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// The type of the account group. Valid values:
        /// 
        /// *   RD: global account group.
        /// *   CUSTOM: custom account group. This is the default value.
        /// </summary>
        [NameInMap("AggregatorType")]
        [Validation(Required=false)]
        public string AggregatorType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The `ClientToken` value can contain only ASCII characters and cannot exceed 64 characters in length.
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

    }

}

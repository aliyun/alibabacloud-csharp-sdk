// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAccountRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account that corresponds to the member.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The new type of the member. Valid values:
        /// 
        /// *   ResourceAccount: resource account
        /// *   CloudAccount: cloud account
        /// 
        /// >  You can configure either the `NewDisplayName` or `NewAccountType` parameter.
        /// </summary>
        [NameInMap("NewAccountType")]
        [Validation(Required=false)]
        public string NewAccountType { get; set; }

        /// <summary>
        /// The new display name of the member.
        /// 
        /// >  You can configure either the `NewDisplayName` or `NewAccountType` parameter.
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

    }

}

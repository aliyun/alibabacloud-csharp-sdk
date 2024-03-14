// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateAccountRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the member.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The new type of the member. Valid values:
        /// 
        /// *   ResourceAccount: resource account
        /// *   CloudAccount: cloud account
        /// 
        /// > You can specify either `NewDisplayName` or `NewAccountType`.
        /// </summary>
        [NameInMap("NewAccountType")]
        [Validation(Required=false)]
        public string NewAccountType { get; set; }

        /// <summary>
        /// The new display name of the member.
        /// 
        /// > You can specify either `NewDisplayName` or `NewAccountType`.
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DeleteAccountShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of the check items that you can choose to ignore for the member deletion.
        /// 
        /// You can obtain the IDs from the response of the [GetAccountDeletionCheckResult](~~GetAccountDeletionCheckResult~~) operation.
        /// </summary>
        [NameInMap("AbandonableCheckId")]
        [Validation(Required=false)]
        public string AbandonableCheckIdShrink { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member that you want to delete.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}

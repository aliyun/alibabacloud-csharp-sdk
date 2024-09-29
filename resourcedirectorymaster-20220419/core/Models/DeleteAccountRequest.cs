// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DeleteAccountRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the check items that you can choose to ignore for the member deletion.</para>
        /// <para>You can obtain the IDs from the response of the <a href="~~GetAccountDeletionCheckResult~~">GetAccountDeletionCheckResult</a> operation.</para>
        /// </summary>
        [NameInMap("AbandonableCheckId")]
        [Validation(Required=false)]
        public List<string> AbandonableCheckId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169946124551****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}

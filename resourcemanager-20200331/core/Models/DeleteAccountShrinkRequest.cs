// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DeleteAccountShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item that you can choose to abandon and continue with the member deletion.</para>
        /// <para>You can obtain this ID from the AbandonableChecks response parameter of <a href="https://help.aliyun.com/document_detail/448775.html">GetAccountDeletionCheckResult</a>.</para>
        /// </summary>
        [NameInMap("AbandonableCheckId")]
        [Validation(Required=false)]
        public string AbandonableCheckIdShrink { get; set; }

        /// <summary>
        /// <para>The ID of the member to delete.</para>
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

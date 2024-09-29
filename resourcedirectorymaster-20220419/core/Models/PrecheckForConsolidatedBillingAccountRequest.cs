// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class PrecheckForConsolidatedBillingAccountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the management account or member to be used as a main financial account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111***089</para>
        /// </summary>
        [NameInMap("BillingAccountId")]
        [Validation(Required=false)]
        public string BillingAccountId { get; set; }

    }

}

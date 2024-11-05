// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class DeductOutstandingBalanceRequest : TeaModel {
        /// <summary>
        /// <para>The Deducted Credit to be offset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DeductAmount")]
        [Validation(Required=false)]
        public string DeductAmount { get; set; }

        /// <summary>
        /// <para>Account UID of Distribution Customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1133166938931507</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}

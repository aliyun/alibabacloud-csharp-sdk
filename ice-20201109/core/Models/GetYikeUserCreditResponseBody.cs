// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetYikeUserCreditResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CreditTotal")]
        [Validation(Required=false)]
        public string CreditTotal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CreditUsage")]
        [Validation(Required=false)]
        public string CreditUsage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

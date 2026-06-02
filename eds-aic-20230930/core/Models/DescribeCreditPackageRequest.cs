// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCreditPackageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>crp-xagydbhfkah****</para>
        /// </summary>
        [NameInMap("CreditPackageId")]
        [Validation(Required=false)]
        public string CreditPackageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("CreditPackageStatus")]
        [Validation(Required=false)]
        public string CreditPackageStatus { get; set; }

    }

}

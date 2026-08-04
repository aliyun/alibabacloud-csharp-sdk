// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class FindFinanceTaxRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HId")]
        [Validation(Required=false)]
        public long? HId { get; set; }

        [NameInMap("TaxVersion")]
        [Validation(Required=false)]
        public string TaxVersion { get; set; }

    }

}

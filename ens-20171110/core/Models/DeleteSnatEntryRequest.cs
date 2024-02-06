// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSnatEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the SNAT entry that you want to delete.
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

    }

}

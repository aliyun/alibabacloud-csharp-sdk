// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteForwardEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the DNAT entry that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

    }

}

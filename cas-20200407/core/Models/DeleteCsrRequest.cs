// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeleteCsrRequest : TeaModel {
        /// <summary>
        /// The ID of the CSR.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CsrId")]
        [Validation(Required=false)]
        public long? CsrId { get; set; }

    }

}

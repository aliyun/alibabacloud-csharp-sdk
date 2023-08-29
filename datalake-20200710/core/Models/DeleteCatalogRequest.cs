// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class DeleteCatalogRequest : TeaModel {
        /// <summary>
        /// CatalogId
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

    }

}

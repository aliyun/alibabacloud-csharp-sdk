// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductRequest : TeaModel {
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        [NameInMap("Before")]
        [Validation(Required=false)]
        public string Before { get; set; }

        /// <summary>
        /// CatalogId
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Waba Id。
        /// </summary>
        [NameInMap("WabaId")]
        [Validation(Required=false)]
        public string WabaId { get; set; }

    }

}

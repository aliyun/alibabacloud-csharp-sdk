// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductRequest : TeaModel {
        /// <summary>
        /// The cursor that points to the end of the page of the returned data.
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        /// <summary>
        /// The cursor that points to the beginning of the page of the returned data.
        /// </summary>
        [NameInMap("Before")]
        [Validation(Required=false)]
        public string Before { get; set; }

        /// <summary>
        /// The catalog ID.
        /// </summary>
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The fields. Separate multiple fields with commas (,).
        /// 
        ///  see [product fields](~~2579419~~)
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// The number of products to be queried. Valid values: 1 to 1000.
        /// </summary>
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
        /// The ID of the WhatsApp Business account (WABA).
        /// </summary>
        [NameInMap("WabaId")]
        [Validation(Required=false)]
        public string WabaId { get; set; }

    }

}

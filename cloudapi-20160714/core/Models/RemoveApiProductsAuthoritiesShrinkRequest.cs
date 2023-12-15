// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveApiProductsAuthoritiesShrinkRequest : TeaModel {
        /// <summary>
        /// The API products.
        /// </summary>
        [NameInMap("ApiProductIds")]
        [Validation(Required=false)]
        public string ApiProductIdsShrink { get; set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

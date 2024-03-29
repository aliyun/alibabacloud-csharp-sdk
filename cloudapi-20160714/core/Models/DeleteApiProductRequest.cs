// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteApiProductRequest : TeaModel {
        /// <summary>
        /// The ID of the API product.
        /// </summary>
        [NameInMap("ApiProductId")]
        [Validation(Required=false)]
        public string ApiProductId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

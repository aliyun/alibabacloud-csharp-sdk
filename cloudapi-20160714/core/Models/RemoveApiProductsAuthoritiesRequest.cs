// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveApiProductsAuthoritiesRequest : TeaModel {
        /// <summary>
        /// The API products.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApiProductIds")]
        [Validation(Required=false)]
        public List<string> ApiProductIds { get; set; }

        /// <summary>
        /// The application ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

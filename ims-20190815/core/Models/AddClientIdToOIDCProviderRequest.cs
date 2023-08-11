/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class AddClientIdToOIDCProviderRequest : TeaModel {
        /// <summary>
        /// The client ID that you want to add.
        /// 
        /// ````
        /// 
        /// The client ID can be up to 64 characters in length.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The name of the OIDC IdP.
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}

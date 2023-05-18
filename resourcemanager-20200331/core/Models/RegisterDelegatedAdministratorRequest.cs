// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class RegisterDelegatedAdministratorRequest : TeaModel {
        /// <summary>
        /// The ID of the member in the resource directory.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The identifier of the trusted service.
        /// 
        /// For more information, see the `Trusted service identifier` column in [Supported trusted services](~~208133~~).
        /// </summary>
        [NameInMap("ServicePrincipal")]
        [Validation(Required=false)]
        public string ServicePrincipal { get; set; }

    }

}

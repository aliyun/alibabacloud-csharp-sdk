// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class DeregisterDelegatedAdministratorRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The identifier of the trusted service.
        /// </summary>
        [NameInMap("ServicePrincipal")]
        [Validation(Required=false)]
        public string ServicePrincipal { get; set; }

    }

}

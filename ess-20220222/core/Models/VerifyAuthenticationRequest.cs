// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class VerifyAuthenticationRequest : TeaModel {
        /// <summary>
        /// Specifies whether to check only the authorization status. Valid values:
        /// 
        /// *   true: checks only the authorization status. The service-linked role is not created.
        /// *   false (default): checks the authorization status and resource usage.
        /// </summary>
        [NameInMap("OnlyCheck")]
        [Validation(Required=false)]
        public bool? OnlyCheck { get; set; }

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
        /// The ID of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}

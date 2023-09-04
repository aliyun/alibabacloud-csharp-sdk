// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateSCIMServerCredentialStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the SCIM credential.
        /// </summary>
        [NameInMap("CredentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The new status of the SCIM credential. Valid values:
        /// 
        /// *   Enabled: The SCIM credential is enabled.
        /// *   Disabled: The SCIM credential is disabled.
        /// </summary>
        [NameInMap("NewStatus")]
        [Validation(Required=false)]
        public string NewStatus { get; set; }

    }

}

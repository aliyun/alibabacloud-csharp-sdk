// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ResetHostAccountCredentialRequest : TeaModel {
        /// <summary>
        /// ResetHostAccountCredential
        /// </summary>
        [NameInMap("CredentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// WB662865
        /// </summary>
        [NameInMap("HostAccountId")]
        [Validation(Required=false)]
        public string HostAccountId { get; set; }

        /// <summary>
        /// Deletes the logon credential of a specified host account of a specified Bastionhost instance. The logon credential can be the password or SSH private key.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// ResetHostAccountCredential
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

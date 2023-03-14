// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ResetHostAccountCredentialRequest : TeaModel {
        /// <summary>
        /// The type of the logon credential that you want to delete. Valid values:
        /// 
        /// *   **Password**: You want to delete the password.
        /// *   **PrivateKey**: You want to delete the SSH private key.
        /// </summary>
        [NameInMap("CredentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// The ID of the host account for which the logon credential is to be deleted.
        /// 
        /// >  You can call the [ListHostAccounts](~~204372~~) operation to query the ID of the host account.
        /// </summary>
        [NameInMap("HostAccountId")]
        [Validation(Required=false)]
        public string HostAccountId { get; set; }

        /// <summary>
        /// The ID of the Bastionhost instance where you want to delete the logon credential for the host account.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the Bastionhost instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the Bastionhost instance where you want to delete the logon credential for the host account.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

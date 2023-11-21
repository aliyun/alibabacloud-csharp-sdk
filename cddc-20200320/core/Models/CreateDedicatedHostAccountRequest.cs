// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateDedicatedHostAccountRequest : TeaModel {
        /// <summary>
        /// The name of the host account.
        /// 
        /// *   The name must be 2 to 16 characters in length.
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit.
        /// *   The name can contain lowercase letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the host account.
        /// 
        /// *   The password must be 6 to 32 characters in length.
        /// *   The password must contain three of the following character types: upper letters, lower letters, digits, and special characters.
        /// *   The password can contain the following special characters: `! @ # $ % ^ & * ( ) _ + - =`
        /// 
        /// >  If your host runs SQL Server, the password cannot contain the account name (case-insensitive).
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The type of the host account. Valid values:
        /// 
        /// *   **Normal**: standard account.
        /// *   **Admin**: administrator account.
        /// 
        /// For more information, see [Host permissions](~~176240~~).
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The ID of the bastion host with which the host is associated. You can log on to the ApsaraDB for MyBase console and go to the **Bastion Hosts** page to view the bastion host ID.
        /// </summary>
        [NameInMap("BastionInstanceId")]
        [Validation(Required=false)]
        public string BastionInstanceId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The host ID. You can call the [DescribeDedicatedHosts](~~200944~~) operation to query the host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the host. You can call the [DescribeDedicatedHostAttribute](~~213010~~) operation to query the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

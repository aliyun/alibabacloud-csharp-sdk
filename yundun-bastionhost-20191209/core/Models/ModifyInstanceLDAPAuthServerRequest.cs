// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceLDAPAuthServerRequest : TeaModel {
        /// <summary>
        /// The username of the account that is used for the LDAP server.
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public string Account { get; set; }

        /// <summary>
        /// The Base distinguished name (DN).
        /// </summary>
        [NameInMap("BaseDN")]
        [Validation(Required=false)]
        public string BaseDN { get; set; }

        /// <summary>
        /// The field that is used to indicate the email address of a user on the LDAP server.
        /// </summary>
        [NameInMap("EmailMapping")]
        [Validation(Required=false)]
        public string EmailMapping { get; set; }

        /// <summary>
        /// The condition that is used to filter users.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// The ID of the bastion host. You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to support SSL. Valid values:
        /// 
        /// *   **true**: supports SSL.
        /// *   **false**: does not support SSL.
        /// </summary>
        [NameInMap("IsSSL")]
        [Validation(Required=false)]
        public string IsSSL { get; set; }

        /// <summary>
        /// The field that is used to indicate the logon name of a user on the LDAP server.
        /// </summary>
        [NameInMap("LoginNameMapping")]
        [Validation(Required=false)]
        public string LoginNameMapping { get; set; }

        /// <summary>
        /// The field that is used to indicate the mobile phone number of a user on the LDAP server.
        /// </summary>
        [NameInMap("MobileMapping")]
        [Validation(Required=false)]
        public string MobileMapping { get; set; }

        /// <summary>
        /// The field that is used to indicate the name of a user on the LDAP server.
        /// </summary>
        [NameInMap("NameMapping")]
        [Validation(Required=false)]
        public string NameMapping { get; set; }

        /// <summary>
        /// The password of the account that is used for the LDAP server.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The port that is used to access the LDAP server.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The region ID of the bastion host. For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The address of the LDAP server.
        /// </summary>
        [NameInMap("Server")]
        [Validation(Required=false)]
        public string Server { get; set; }

        /// <summary>
        /// The address of the secondary LDAP server.
        /// </summary>
        [NameInMap("StandbyServer")]
        [Validation(Required=false)]
        public string StandbyServer { get; set; }

    }

}

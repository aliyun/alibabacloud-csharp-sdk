// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaInstanceRequest : TeaModel {
        /// <summary>
        /// The alert settings. Valid value: INHERITED, which indicates that the backup client sends alert notifications in the same way as the backup vault.
        /// </summary>
        [NameInMap("AlertSetting")]
        [Validation(Required=false)]
        public string AlertSetting { get; set; }

        /// <summary>
        /// The ID of the SAP HANA instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the SAP HANA instance.
        /// </summary>
        [NameInMap("HanaName")]
        [Validation(Required=false)]
        public string HanaName { get; set; }

        /// <summary>
        /// The private or internal IP address of the host where the primary node of the SAP HANA instance resides.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The instance number of the SAP HANA system.
        /// </summary>
        [NameInMap("InstanceNumber")]
        [Validation(Required=false)]
        public int? InstanceNumber { get; set; }

        /// <summary>
        /// The password that is used to connect with the SAP HANA database.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to connect with the SAP HANA database over Secure Sockets Layer (SSL). Valid values:
        /// 
        /// *   true: The SAP HANA database is connected over SSL.
        /// *   false: The SAP HANA database is not connected over SSL.
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// The username of the SYSTEMDB database.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Specifies whether to verify the SSL certificate of the SAP HANA database. Valid values:
        /// 
        /// *   true: The SSL certificate of the SAP HANA instance is verified.
        /// *   false: The SSL certificate of the SAP HANA instance is not verified.
        /// </summary>
        [NameInMap("ValidateCertificate")]
        [Validation(Required=false)]
        public bool? ValidateCertificate { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}

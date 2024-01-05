// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateHanaInstanceRequest : TeaModel {
        /// <summary>
        /// The alert settings. Valid value: INHERITED, which indicates that the backup client sends alert notifications in the same way as the backup vault.
        /// </summary>
        [NameInMap("AlertSetting")]
        [Validation(Required=false)]
        public string AlertSetting { get; set; }

        /// <summary>
        /// The IDs of ECS instances that host the SAP HANA instance to be registered. HBR installs backup clients on the specified ECS instances.
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

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
        /// The security identifier (SID) of the SAP HANA database.
        /// 
        /// For more information, see [How to find sid user and instance number of HANA db?](https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?spm=a2c4g.11186623.0.0.55c34b4ftZeXNK)
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// Specifies whether to connect with the SAP HANA database over Secure Sockets Layer (SSL).
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
        /// Specifies whether to verify the SSL certificate of the SAP HANA database.
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

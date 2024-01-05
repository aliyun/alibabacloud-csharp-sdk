// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateClientsRequest : TeaModel {
        /// <summary>
        /// The alert settings. Valid value: INHERITED, which indicates that the HBR client sends alert notifications by using the same method configured for the backup vault.
        /// </summary>
        [NameInMap("AlertSetting")]
        [Validation(Required=false)]
        public string AlertSetting { get; set; }

        /// <summary>
        /// The installation information of the HBR clients.
        /// </summary>
        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public string ClientInfo { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to transmit data over HTTPS. Valid values:
        /// 
        /// *   true: transmits data over HTTPS.
        /// *   false: transmits data over HTTP.
        /// </summary>
        [NameInMap("UseHttps")]
        [Validation(Required=false)]
        public bool? UseHttps { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}

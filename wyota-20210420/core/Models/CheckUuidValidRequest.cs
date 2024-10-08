// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class CheckUuidValidRequest : TeaModel {
        [NameInMap("Bluetooth")]
        [Validation(Required=false)]
        public string Bluetooth { get; set; }

        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public string BuildId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChipId")]
        [Validation(Required=false)]
        public string ChipId { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("EtherMac")]
        [Validation(Required=false)]
        public string EtherMac { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("Wlan")]
        [Validation(Required=false)]
        public string Wlan { get; set; }

        [NameInMap("WosAppVersion")]
        [Validation(Required=false)]
        public string WosAppVersion { get; set; }

    }

}

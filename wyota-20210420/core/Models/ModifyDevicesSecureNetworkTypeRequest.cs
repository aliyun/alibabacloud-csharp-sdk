// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ModifyDevicesSecureNetworkTypeRequest : TeaModel {
        [NameInMap("AllDevices")]
        [Validation(Required=false)]
        public long? AllDevices { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecureNetworkType")]
        [Validation(Required=false)]
        public string SecureNetworkType { get; set; }

        [NameInMap("SerialNos")]
        [Validation(Required=false)]
        public string SerialNos { get; set; }

    }

}

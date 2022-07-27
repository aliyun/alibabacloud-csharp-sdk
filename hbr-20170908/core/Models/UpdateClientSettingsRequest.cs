// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateClientSettingsRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("DataNetworkType")]
        [Validation(Required=false)]
        public string DataNetworkType { get; set; }

        [NameInMap("DataProxySetting")]
        [Validation(Required=false)]
        public string DataProxySetting { get; set; }

        [NameInMap("MaxCpuCore")]
        [Validation(Required=false)]
        public int? MaxCpuCore { get; set; }

        [NameInMap("MaxWorker")]
        [Validation(Required=false)]
        public int? MaxWorker { get; set; }

        [NameInMap("ProxyHost")]
        [Validation(Required=false)]
        public string ProxyHost { get; set; }

        [NameInMap("ProxyPassword")]
        [Validation(Required=false)]
        public string ProxyPassword { get; set; }

        [NameInMap("ProxyPort")]
        [Validation(Required=false)]
        public int? ProxyPort { get; set; }

        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("UseHttps")]
        [Validation(Required=false)]
        public bool? UseHttps { get; set; }

        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}

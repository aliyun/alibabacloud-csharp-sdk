// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SetNetworkBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>Domain name blacklist.</para>
        /// <remarks>
        /// <para>Supports a maximum of 200 domain names.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DomainBlacklist")]
        [Validation(Required=false)]
        public List<string> DomainBlacklist { get; set; }

        /// <summary>
        /// <para>IP address blacklist.</para>
        /// <remarks>
        /// <para>Supports a maximum of 200 IP addresses or IP address segments.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IpBlacklist")]
        [Validation(Required=false)]
        public List<string> IpBlacklist { get; set; }

    }

}

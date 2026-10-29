// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class SetNetworkBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The domain name blacklist.</para>
        /// <remarks>
        /// <para>A maximum of 200 domain names are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DomainBlacklist")]
        [Validation(Required=false)]
        public List<string> DomainBlacklist { get; set; }

        /// <summary>
        /// <para>The IP address blacklist.</para>
        /// <remarks>
        /// <para>A maximum of 200 IP addresses or CIDR blocks are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IpBlacklist")]
        [Validation(Required=false)]
        public List<string> IpBlacklist { get; set; }

    }

}

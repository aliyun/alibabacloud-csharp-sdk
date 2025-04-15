// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DeleteInstanceIpWhitelistRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        [Obsolete]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// </summary>
        [NameInMap("ipWhitelists")]
        [Validation(Required=false)]
        public List<string> IpWhitelists { get; set; }

    }

}

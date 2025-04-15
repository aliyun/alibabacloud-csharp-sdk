// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DeleteInstanceIpWhitelistShrinkRequest : TeaModel {
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
        public string IpWhitelistsShrink { get; set; }

    }

}

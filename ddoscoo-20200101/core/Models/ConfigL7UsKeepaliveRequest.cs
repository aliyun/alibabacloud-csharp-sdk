// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigL7UsKeepaliveRequest : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("DownstreamKeepalive")]
        [Validation(Required=false)]
        public string DownstreamKeepalive { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpstreamKeepalive")]
        [Validation(Required=false)]
        public string UpstreamKeepalive { get; set; }

    }

}

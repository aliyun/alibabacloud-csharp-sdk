// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class IPConfig : TeaModel {
        /// <summary>
        /// <para>The description of the IP configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>应用固定出口</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IP address or CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>203.0.113.10</para>
        /// </summary>
        [NameInMap("ipAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

    }

}

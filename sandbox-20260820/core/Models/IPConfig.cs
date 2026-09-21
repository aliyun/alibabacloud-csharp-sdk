// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class IPConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>办公网出口地址</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>203.0.113.25/32</para>
        /// </summary>
        [NameInMap("ipAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

    }

}

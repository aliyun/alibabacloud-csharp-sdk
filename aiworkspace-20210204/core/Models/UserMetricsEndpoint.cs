// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UserMetricsEndpoint : TeaModel {
        /// <summary>
        /// <para>The HTTP path of the metric collection API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/metrics</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The port number on which the metric collection service listens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40002</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}

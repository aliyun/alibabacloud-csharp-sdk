// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class TrafficControlTaskTrafficInfoTaskTrafficsValue : TeaModel {
        /// <summary>
        /// <para>The reported traffic for this experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Traffic")]
        [Validation(Required=false)]
        public double? Traffic { get; set; }

    }

}

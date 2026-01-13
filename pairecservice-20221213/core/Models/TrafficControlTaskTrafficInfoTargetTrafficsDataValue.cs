// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class TrafficControlTaskTrafficInfoTargetTrafficsDataValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Traffic")]
        [Validation(Required=false)]
        public double? Traffic { get; set; }

        [NameInMap("RecorfTime")]
        [Validation(Required=false)]
        public long? RecorfTime { get; set; }

    }

}

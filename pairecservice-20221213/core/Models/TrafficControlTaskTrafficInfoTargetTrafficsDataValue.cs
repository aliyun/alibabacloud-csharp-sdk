// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class TrafficControlTaskTrafficInfoTargetTrafficsDataValue : TeaModel {
        /// <summary>
        /// <para>The reported traffic for this target within the experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Traffic")]
        [Validation(Required=false)]
        public double? Traffic { get; set; }

        /// <summary>
        /// <para>The timestamp indicating when the data was reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1760319273</para>
        /// </summary>
        [NameInMap("RecordTime")]
        [Validation(Required=false)]
        public long? RecordTime { get; set; }

    }

}

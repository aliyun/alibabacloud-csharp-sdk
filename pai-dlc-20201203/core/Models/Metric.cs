// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Metric : TeaModel {
        /// <summary>
        /// <para>The timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616987726587</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The value of the monitoring data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23.45</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}

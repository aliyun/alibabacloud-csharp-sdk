// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobMetric : TeaModel {
        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCpu")]
        [Validation(Required=false)]
        public double? TotalCpu { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("totalMemoryByte")]
        [Validation(Required=false)]
        public long? TotalMemoryByte { get; set; }

    }

}

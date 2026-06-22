// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OpenBackupAutoConfigRequest : TeaModel {
        /// <summary>
        /// <para>The number of servers included in a single batch when the anti-ransomware managed service automatically generates policies.</para>
        /// <remarks>
        /// <para>The maximum value is 50. If you specify a value greater than 50, the value is set to 50.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxBatchSize")]
        [Validation(Required=false)]
        public int? MaxBatchSize { get; set; }

    }

}

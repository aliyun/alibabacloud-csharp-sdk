// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeLocalAvailableRecoveryTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze3ngi149b313***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The start of the time range available for recovery.</para>
        /// <remarks>
        /// <para>This is calculated based on level-1 backups and does not include level-2 backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-10T14:19:48Z</para>
        /// </summary>
        [NameInMap("RecoveryBeginTime")]
        [Validation(Required=false)]
        public string RecoveryBeginTime { get; set; }

        /// <summary>
        /// <para>The end of the time range available for recovery.</para>
        /// <remarks>
        /// <para>This is calculated based on level-1 backups and does not include level-2 backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-17T08:56:45Z</para>
        /// </summary>
        [NameInMap("RecoveryEndTime")]
        [Validation(Required=false)]
        public string RecoveryEndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EA0E6F8-BDB2-17B2-9567-591F6B3D7***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

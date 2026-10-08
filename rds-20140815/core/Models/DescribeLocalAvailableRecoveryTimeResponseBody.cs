// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeLocalAvailableRecoveryTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1f****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the restorable time range for backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-11T09:48:52Z</para>
        /// </summary>
        [NameInMap("RecoveryBeginTime")]
        [Validation(Required=false)]
        public string RecoveryBeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the restorable time range for backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-18T08:03:09Z</para>
        /// </summary>
        [NameInMap("RecoveryEndTime")]
        [Validation(Required=false)]
        public string RecoveryEndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>291534CC-922B-55D5-8657-B29****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup task ID. For cluster instances created before December 5, 2023, the return value consists of the job IDs of individual child DB nodes. For example, for a cluster instance with two shards, the BackupJobID value is returned in the format of &quot;10000,10001&quot;. For cluster instances created on or after December 5, 2023, all DB nodes in a cluster are described by a single job ID. You only need to use this single job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1022,2480&quot;</para>
        /// </summary>
        [NameInMap("BackupJobID")]
        [Validation(Required=false)]
        public string BackupJobID { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FF6158E-3394-4A90-B634-79C49184****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateSupabaseBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the backup job. You can call ListSupabaseBackupJobs to query the status and progress of the corresponding job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public long? BackupJobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

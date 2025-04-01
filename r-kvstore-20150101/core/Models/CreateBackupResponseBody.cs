// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the backup task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1162****</para>
        /// </summary>
        [NameInMap("BackupJobID")]
        [Validation(Required=false)]
        public string BackupJobID { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FF6158E-3394-4A90-B634-79C49184****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

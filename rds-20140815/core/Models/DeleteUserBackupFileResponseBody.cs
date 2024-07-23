// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteUserBackupFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the deleted full backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-w1haya7e4i25********</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F28AE40B-203B-4CFE-B81F-FD981CD97B17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

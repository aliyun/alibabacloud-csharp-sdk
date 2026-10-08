// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpdateUserBackupFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The user backup ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-lvn2365ev9f1****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29EBB093-DBD8-5EEB-841D-E611B88CDE4B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

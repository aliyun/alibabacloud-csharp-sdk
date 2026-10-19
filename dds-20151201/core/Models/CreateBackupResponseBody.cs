// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the backup.</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter will be deprecated soon. To obtain the backup ID, call the <a href="https://help.aliyun.com/document_detail/468441.html">DescribeBackups</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5664****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The ID of the backup job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>775051</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public string BackupJobId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7016B12F-7F64-40A4-BAFF-013F02AC82FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

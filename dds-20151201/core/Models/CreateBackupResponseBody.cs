// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup ID.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. To obtain the backup ID, call the <a href="https://help.aliyun.com/document_detail/468441.html">DescribeBackups</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5664****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The backup job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>775051</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public string BackupJobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7016B12F-7F64-40A4-BAFF-013F02AC82FC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

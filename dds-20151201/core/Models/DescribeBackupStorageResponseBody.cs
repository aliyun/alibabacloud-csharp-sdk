// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The free backup quota for the instance. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42949672960</para>
        /// </summary>
        [NameInMap("FreeSize")]
        [Validation(Required=false)]
        public long? FreeSize { get; set; }

        /// <summary>
        /// <para>The storage space used by full backups. Unit: bytes.</para>
        /// <remarks>
        /// <para>Instances that use cloud disks are backed up using snapshots. The size of a full backup is the total size of the snapshot chain.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>789221621</para>
        /// </summary>
        [NameInMap("FullStorageSize")]
        [Validation(Required=false)]
        public long? FullStorageSize { get; set; }

        /// <summary>
        /// <para>The storage space used by log backups. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7892216</para>
        /// </summary>
        [NameInMap("LogStorageSize")]
        [Validation(Required=false)]
        public long? LogStorageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D648B367-15B6-1B42-BD4B-4XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

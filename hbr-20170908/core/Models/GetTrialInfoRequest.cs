// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GetTrialInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>OSS</b>. The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>NAS</b>. The time when the file system was created. UNIX timestamp, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1607436917</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>NAS</b>. The ID of the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The data source type. Only free trial information of OSS backup and NAS backup can be queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}

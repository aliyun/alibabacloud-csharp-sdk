// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetBackupConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Backup scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public int? BackupMode { get; set; }

        /// <summary>
        /// <para>File server OSS Bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>buckect_test</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>Whether it is enabled. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled</description></item>
        /// <item><description><b>false</b>: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Whether to enable backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableBackup")]
        [Validation(Required=false)]
        public bool? EnableBackup { get; set; }

        /// <summary>
        /// <para>Whether to enable audio backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableBackupVoice")]
        [Validation(Required=false)]
        public bool? EnableBackupVoice { get; set; }

        /// <summary>
        /// <para>Expiration time in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ExpireSeconds")]
        [Validation(Required=false)]
        public int? ExpireSeconds { get; set; }

        /// <summary>
        /// <para>Modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-17 12:29:56</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun/template/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>Audio backup path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/back</para>
        /// </summary>
        [NameInMap("PathVoice")]
        [Validation(Required=false)]
        public string PathVoice { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>ID assigned by the backend, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1772612608370735</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeBackupSetDownloadLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupSetDownloadLinkResponseBodyData Data { get; set; }
        public class DescribeBackupSetDownloadLinkResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The restorable time of the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("BackupRestorableTime")]
            [Validation(Required=false)]
            public string BackupRestorableTime { get; set; }

            /// <summary>
            /// <para>The ID of the target backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bak-4n****gacpa8</para>
            /// </summary>
            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            /// <summary>
            /// <para>The time when the download task corresponding to the target backup set was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-22T17:04:18</para>
            /// </summary>
            [NameInMap("DownloadTaskCreateTime")]
            [Validation(Required=false)]
            public string DownloadTaskCreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the download task corresponding to the target backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000002</para>
            /// </summary>
            [NameInMap("DownloadTaskId")]
            [Validation(Required=false)]
            public long? DownloadTaskId { get; set; }

            /// <summary>
            /// <para>The status of the download task corresponding to the target backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DownloadTaskStatus")]
            [Validation(Required=false)]
            public string DownloadTaskStatus { get; set; }

            /// <summary>
            /// <para>The internal URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://bucket.oss-region-internal.aliyuncs.com/xxxxx">http://bucket.oss-region-internal.aliyuncs.com/xxxxx</a></para>
            /// </summary>
            [NameInMap("InternalUrl")]
            [Validation(Required=false)]
            public string InternalUrl { get; set; }

            /// <summary>
            /// <para>The validity period of the URL, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("UrlAliveTime")]
            [Validation(Required=false)]
            public long? UrlAliveTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-04 17:39:49</para>
            /// </summary>
            [NameInMap("UrlExpiredTime")]
            [Validation(Required=false)]
            public string UrlExpiredTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

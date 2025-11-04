// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetStorageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>73-8B78-5D86-A50C-49B96C</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage configurations.</para>
        /// </summary>
        [NameInMap("StorageInfoList")]
        [Validation(Required=false)]
        public List<GetStorageListResponseBodyStorageInfoList> StorageInfoList { get; set; }
        public class GetStorageListResponseBodyStorageInfoList : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-06T01:55:07Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether it is the default storage location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultStorage")]
            [Validation(Required=false)]
            public bool? DefaultStorage { get; set; }

            /// <summary>
            /// <para>Indicates whether temporary files created during editing processes are stored in this location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EditingTempFileStorage")]
            [Validation(Required=false)]
            public bool? EditingTempFileStorage { get; set; }

            /// <summary>
            /// <para>The time when the configuration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-06T03:07:07Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-path/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The OSS storage status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>your-bucket</para>
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vod_oss_bucket</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

    }

}

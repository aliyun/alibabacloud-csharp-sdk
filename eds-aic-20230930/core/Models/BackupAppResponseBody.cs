// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BackupAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances that are backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The response elements.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BackupAppResponseBodyData> Data { get; set; }
        public class BackupAppResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud phone instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-34pqe4r0kd9kn****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the backup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bf-b0qbg3pbpjkn7****</para>
            /// </summary>
            [NameInMap("BackupFileId")]
            [Validation(Required=false)]
            public string BackupFileId { get; set; }

            /// <summary>
            /// <para>The name of the backup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyBackup</para>
            /// </summary>
            [NameInMap("BackupFileName")]
            [Validation(Required=false)]
            public string BackupFileName { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-4ks224ujixw****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the batch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-14xwibw7pyrjd****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class BackupFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of instances that are backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The object that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C8439B9-7DBF-57F4-92AE-55A9B9D3****</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<BackupFileResponseBodyData> Data { get; set; }
        public class BackupFileResponseBodyData : TeaModel {
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
            /// <para>a-58ftsoo90p0qa****.ab</para>
            /// </summary>
            [NameInMap("BackupFileName")]
            [Validation(Required=false)]
            public string BackupFileName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-22ex666a5mco5****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C8439B9-7DBF-57F4-92AE-55A9B9D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the batch task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-22ex666a5mco5****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

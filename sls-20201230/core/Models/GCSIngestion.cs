// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GCSIngestion : TeaModel {
        /// <summary>
        /// <para>The GCS ingestion configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public GCSIngestionConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>Output only. The creation time of the job, as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714360481</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>A user-friendly description for the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gcs ingestion</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name for the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gcs ingestion</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Output only. The last modified time of the job, as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1714360581</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingest-gcs-123456</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c7f01719d9feb105fc9d8df92af62010</para>
        /// </summary>
        [NameInMap("scheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        /// <summary>
        /// <para>Output only. The ingestion status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

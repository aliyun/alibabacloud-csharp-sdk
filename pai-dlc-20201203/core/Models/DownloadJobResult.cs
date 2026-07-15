// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DownloadJobResult : TeaModel {
        /// <summary>
        /// <para>The display name of the download job.</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The ID of the download job.</para>
        /// </summary>
        [NameInMap("DownloadJobId")]
        [Validation(Required=false)]
        public string DownloadJobId { get; set; }

        /// <summary>
        /// <para>A temporary, pre-signed URL for downloading the result file.</para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The completion time of the download job, in UTC format.</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of file to download, such as <c>logs</c> or <c>output</c>.</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The creation time of the download job, in UTC format.</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The last modification time of the download job, in UTC format.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The number of log entries included in the download.</para>
        /// </summary>
        [NameInMap("LogCount")]
        [Validation(Required=false)]
        public int? LogCount { get; set; }

        /// <summary>
        /// <para>The IDs of the pods for the source job.</para>
        /// </summary>
        [NameInMap("PodIds")]
        [Validation(Required=false)]
        public List<string> PodIds { get; set; }

        /// <summary>
        /// <para>The UIDs of the pods for the source job.</para>
        /// </summary>
        [NameInMap("PodUids")]
        [Validation(Required=false)]
        public List<string> PodUids { get; set; }

        /// <summary>
        /// <para>The ID of the source job whose results are downloaded.</para>
        /// </summary>
        [NameInMap("SourceJobId")]
        [Validation(Required=false)]
        public string SourceJobId { get; set; }

        /// <summary>
        /// <para>The start time of the download job, in UTC format.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the download job. Valid values: <c>Running</c>, <c>Succeeded</c>, and <c>Failed</c>.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the tenant that the job belongs to.</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The type of the download job.</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the download URL expires, in UTC format.</para>
        /// </summary>
        [NameInMap("UrlExpireTime")]
        [Validation(Required=false)]
        public string UrlExpireTime { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the job.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the job was created.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

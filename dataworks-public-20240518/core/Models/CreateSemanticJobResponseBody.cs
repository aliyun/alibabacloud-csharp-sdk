// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSemanticJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The saved semantic job definition. Use Data.Name to call RunSemanticJob, DeleteSemanticJob, ListSemanticJobRuns, and DownloadSemanticResults.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSemanticJobResponseBodyData Data { get; set; }
        public class CreateSemanticJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The job creator identifier, equivalent to UserId, used to display creation ownership.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-demo</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creation time of the job definition, expressed as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700000000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the job definition, expressed as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700000000000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The internal unique ID of the job definition, which identifies the job created by this call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The saved job name. Use this value for subsequent operations such as running, deleting, querying run records, and downloading results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>semantic-job-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID to which the job belongs. Use this value as the ProjectId for GetSemanticJobDetail, GetSemanticJobLog, and KillSemanticJob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of associated uploaded file IDs. For singleTableFile, the single file in this list is read at runtime.</para>
            /// </summary>
            [NameInMap("ReferenceFileIds")]
            [Validation(Required=false)]
            public List<string> ReferenceFileIds { get; set; }

            /// <summary>
            /// <para>The list of associated external reference file URIs. For singleTableFile, the single file in this list is read at runtime.</para>
            /// </summary>
            [NameInMap("ReferenceFileUris")]
            [Validation(Required=false)]
            public List<string> ReferenceFileUris { get; set; }

            /// <summary>
            /// <para>The ID of the resource group that is used when running this job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-demo</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The saved input datasource config, corresponding to the Source in the creation request. The data scope to be analyzed is determined based on this configuration at runtime.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public Dictionary<string, object> Source { get; set; }

            /// <summary>
            /// <para>The saved Source.type data source type, used to quickly identify the job input type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The identifier of the user who created the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-demo</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

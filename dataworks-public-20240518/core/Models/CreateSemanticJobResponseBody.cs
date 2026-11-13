// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSemanticJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The saved semantic task definition. Use <c>Data.Name</c> to call RunSemanticJob, DeleteSemanticJob, ListSemanticJobRuns, and DownloadSemanticResults.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSemanticJobResponseBodyData Data { get; set; }
        public class CreateSemanticJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The identifier of the task creator, which has the same value as <c>UserId</c> and identifies who created the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-demo</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The time when the task definition was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700000000000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task definition was last modified. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700000000000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The internal unique ID of the task definition, which is used to identify the created task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The saved task name. This value is used for subsequent operations such as running, deleting, querying run records, and downloading results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>semantic-job-demo</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace to which the task belongs. This ID is used as the <c>ProjectId</c> for GetSemanticJobDetail, GetSemanticJobLog, and KillSemanticJob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The list of IDs of associated uploaded files. If the source type is <c>singleTableFile</c>, the task reads the only file in the list at runtime.</para>
            /// </summary>
            [NameInMap("ReferenceFileIds")]
            [Validation(Required=false)]
            public List<string> ReferenceFileIds { get; set; }

            /// <summary>
            /// <para>The list of URIs of associated external reference files. If the source type is <c>singleTableFile</c>, the task reads the only file in the list at runtime.</para>
            /// </summary>
            [NameInMap("ReferenceFileUris")]
            [Validation(Required=false)]
            public List<string> ReferenceFileUris { get; set; }

            /// <summary>
            /// <para>The identifier of the resource group to be used when running this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-demo</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The saved input data source configuration, which corresponds to <c>Source</c> in the creation request. The data scope to be analyzed is selected based on this config during runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;maxcompute&quot;,&quot;domain&quot;:&quot;sales&quot;,&quot;pinnedScopeInfo&quot;:[{&quot;type&quot;:&quot;project&quot;,&quot;name&quot;:&quot;mc_project&quot;}]}</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public Dictionary<string, object> Source { get; set; }

            /// <summary>
            /// <para>The saved <c>Source.type</c> data source type, which is used to quickly identify the task input type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The identifier of the user who created the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-demo</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

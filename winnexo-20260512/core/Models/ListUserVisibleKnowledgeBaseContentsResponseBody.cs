// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListUserVisibleKnowledgeBaseContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of skill cards.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListUserVisibleKnowledgeBaseContentsResponseBodyItems> Items { get; set; }
        public class ListUserVisibleKnowledgeBaseContentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The description of the to-do card type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product materials and user instructions</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("directoryKind")]
            [Validation(Required=false)]
            public string DirectoryKind { get; set; }

            /// <summary>
            /// <para>The directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("directoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The last update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source_example</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The item type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resource</para>
            /// </summary>
            [NameInMap("itemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            /// <summary>
            /// <para>Indicates whether the resource has a pending knowledge base submission record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("kbSubmissionPending")]
            [Validation(Required=false)]
            public bool? KbSubmissionPending { get; set; }

            /// <summary>
            /// <para>The name of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Li Si</para>
            /// </summary>
            [NameInMap("modifierName")]
            [Validation(Required=false)]
            public string ModifierName { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product description.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object bindings.</para>
            /// </summary>
            [NameInMap("objectBindings")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ObjectBindings { get; set; }

            /// <summary>
            /// <para>The visibility mode of the knowledge base for digital employees.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("ooVisibilityMode")]
            [Validation(Required=false)]
            public string OoVisibilityMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the item is read-only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("readOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <para>The sharing information.</para>
            /// </summary>
            [NameInMap("shareInfos")]
            [Validation(Required=false)]
            public List<ListUserVisibleKnowledgeBaseContentsResponseBodyItemsShareInfos> ShareInfos { get; set; }
            public class ListUserVisibleKnowledgeBaseContentsResponseBodyItemsShareInfos : TeaModel {
                /// <summary>
                /// <para>The ID of the Ray job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>submission_example</para>
                /// </summary>
                [NameInMap("submissionId")]
                [Validation(Required=false)]
                public string SubmissionId { get; set; }

                /// <summary>
                /// <para>The user ID of the timesheet submitter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("submitterId")]
                [Validation(Required=false)]
                public long? SubmitterId { get; set; }

                /// <summary>
                /// <para>The name of the submitter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("submitterName")]
                [Validation(Required=false)]
                public string SubmitterName { get; set; }

                /// <summary>
                /// <para>The ID of the target directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dir_target</para>
                /// </summary>
                [NameInMap("targetDirectoryId")]
                [Validation(Required=false)]
                public string TargetDirectoryId { get; set; }

                /// <summary>
                /// <para>The name of the target directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shared directory</para>
                /// </summary>
                [NameInMap("targetDirectoryName")]
                [Validation(Required=false)]
                public string TargetDirectoryName { get; set; }

                /// <summary>
                /// <para>The ID of the root directory of the target enterprise knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dir_kb_root</para>
                /// </summary>
                [NameInMap("targetKbRootDirectoryId")]
                [Validation(Required=false)]
                public string TargetKbRootDirectoryId { get; set; }

                /// <summary>
                /// <para>The name of the target enterprise knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product knowledge base</para>
                /// </summary>
                [NameInMap("targetKbRootDirectoryName")]
                [Validation(Required=false)]
                public string TargetKbRootDirectoryName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether shared access is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("shared")]
            [Validation(Required=false)]
            public bool? Shared { get; set; }

            /// <summary>
            /// <para>The number of resources in the FAILED state. This parameter is returned only when the top-level directory list of the knowledge base is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("sourceFailedCount")]
            [Validation(Required=false)]
            public long? SourceFailedCount { get; set; }

            /// <summary>
            /// <para>The ownership type of the knowledge base. Valid values: aliding_kb_doc (DingTalk knowledge base document) and normal (common knowledge).</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("sourceKind")]
            [Validation(Required=false)]
            public string SourceKind { get; set; }

            /// <summary>
            /// <para>The number of resources in the READY state. This parameter is returned only when the top-level directory list of the knowledge base is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceReadyCount")]
            [Validation(Required=false)]
            public long? SourceReadyCount { get; set; }

            /// <summary>
            /// <para>The resource status. This parameter has a value only when itemType is set to resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("sourceStatus")]
            [Validation(Required=false)]
            public string SourceStatus { get; set; }

            /// <summary>
            /// <para>The total number of resources in the directory and its subdirectories. This parameter is returned only when the top-level directory list of the knowledge base is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceTotalCount")]
            [Validation(Required=false)]
            public long? SourceTotalCount { get; set; }

            /// <summary>
            /// <para>The data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. The pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListUserVisibleKnowledgeBaseContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListUserVisibleKnowledgeBaseContentsResponseBodyItems> Items { get; set; }
        public class ListUserVisibleKnowledgeBaseContentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>创建人名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>知识库描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品资料与使用说明</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>目录归属类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("directoryKind")]
            [Validation(Required=false)]
            public string DirectoryKind { get; set; }

            /// <summary>
            /// <para>目录类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("directoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>创建时间戳（毫秒）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>修改时间戳（毫秒）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>目录 ID 或资源 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>source_example</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>内容类型：directory 或 resource</para>
            /// 
            /// <b>Example:</b>
            /// <para>resource</para>
            /// </summary>
            [NameInMap("itemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            /// <summary>
            /// <para>资源是否存在待审批的知识库提交记录</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("kbSubmissionPending")]
            [Validation(Required=false)]
            public bool? KbSubmissionPending { get; set; }

            /// <summary>
            /// <para>更新人名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("modifierName")]
            [Validation(Required=false)]
            public string ModifierName { get; set; }

            /// <summary>
            /// <para>目录或资源名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品说明.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("objectBindings")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ObjectBindings { get; set; }

            /// <summary>
            /// <para>知识库对数字员工的可见模式</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("ooVisibilityMode")]
            [Validation(Required=false)]
            public string OoVisibilityMode { get; set; }

            /// <summary>
            /// <para>是否为只读关联内容</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("readOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            [NameInMap("shareInfos")]
            [Validation(Required=false)]
            public List<ListUserVisibleKnowledgeBaseContentsResponseBodyItemsShareInfos> ShareInfos { get; set; }
            public class ListUserVisibleKnowledgeBaseContentsResponseBodyItemsShareInfos : TeaModel {
                /// <summary>
                /// <para>知识库提交审批单 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>submission_example</para>
                /// </summary>
                [NameInMap("submissionId")]
                [Validation(Required=false)]
                public string SubmissionId { get; set; }

                /// <summary>
                /// <para>提交人用户 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("submitterId")]
                [Validation(Required=false)]
                public long? SubmitterId { get; set; }

                /// <summary>
                /// <para>提交人名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("submitterName")]
                [Validation(Required=false)]
                public string SubmitterName { get; set; }

                /// <summary>
                /// <para>目标目录 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>dir_target</para>
                /// </summary>
                [NameInMap("targetDirectoryId")]
                [Validation(Required=false)]
                public string TargetDirectoryId { get; set; }

                /// <summary>
                /// <para>目标目录名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>共享目录</para>
                /// </summary>
                [NameInMap("targetDirectoryName")]
                [Validation(Required=false)]
                public string TargetDirectoryName { get; set; }

                /// <summary>
                /// <para>目标企业知识库根目录 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>dir_kb_root</para>
                /// </summary>
                [NameInMap("targetKbRootDirectoryId")]
                [Validation(Required=false)]
                public string TargetKbRootDirectoryId { get; set; }

                /// <summary>
                /// <para>目标企业知识库名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>产品知识库</para>
                /// </summary>
                [NameInMap("targetKbRootDirectoryName")]
                [Validation(Required=false)]
                public string TargetKbRootDirectoryName { get; set; }

            }

            /// <summary>
            /// <para>是否已直接共享到企业知识库</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("shared")]
            [Validation(Required=false)]
            public bool? Shared { get; set; }

            /// <summary>
            /// <para>目录 FAILED 资源数</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("sourceFailedCount")]
            [Validation(Required=false)]
            public long? SourceFailedCount { get; set; }

            /// <summary>
            /// <para>资源归属类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("sourceKind")]
            [Validation(Required=false)]
            public string SourceKind { get; set; }

            /// <summary>
            /// <para>目录 READY 资源数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceReadyCount")]
            [Validation(Required=false)]
            public long? SourceReadyCount { get; set; }

            /// <summary>
            /// <para>资源状态；本接口只返回 READY 资源</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("sourceStatus")]
            [Validation(Required=false)]
            public string SourceStatus { get; set; }

            /// <summary>
            /// <para>目录资源总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceTotalCount")]
            [Validation(Required=false)]
            public long? SourceTotalCount { get; set; }

            /// <summary>
            /// <para>资源类型，目录项为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>当前页码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>命中总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListVisibleKnowledgeBaseContentsResponseBody : TeaModel {
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
        public List<ListVisibleKnowledgeBaseContentsResponseBodyItems> Items { get; set; }
        public class ListVisibleKnowledgeBaseContentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>目录创建者姓名（仅根目录列表时返回；下钻场景为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>知识库描述（仅根目录列表时返回；下钻场景为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>目录 KB 归属类型（itemType=directory 时有值）：aliding_kb_root / aliding_kb_internal / normal</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("directoryKind")]
            [Validation(Required=false)]
            public string DirectoryKind { get; set; }

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
            /// <para>唯一标识（目录为 directoryId，资源为 sourceId）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleItemId</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>类型: directory 或 resource</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("itemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("objectBindings")]
            [Validation(Required=false)]
            public List<ListVisibleKnowledgeBaseContentsResponseBodyItemsObjectBindings> ObjectBindings { get; set; }
            public class ListVisibleKnowledgeBaseContentsResponseBodyItemsObjectBindings : TeaModel {
                /// <summary>
                /// <para>对象归属的语义图谱名（object_id 在该 graph 下唯一）</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("graphName")]
                [Validation(Required=false)]
                public string GraphName { get; set; }

                /// <summary>
                /// <para>对象唯一 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleObjectId</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>对象显示名（如客户名称），由图谱 schema 解析；缓存缺失时为 null</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("objectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>对象类型（如 customer / opportunity），对应图谱 schema 中的 object_type</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>对象类型显示名（如&quot;客户&quot;），由图谱 schema 解析；缓存缺失时为 null</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("objectTypeName")]
                [Validation(Required=false)]
                public string ObjectTypeName { get; set; }

            }

            /// <summary>
            /// <para>目录下失败资源数（仅根目录列表时返回；下钻场景为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceFailedCount")]
            [Validation(Required=false)]
            public long? SourceFailedCount { get; set; }

            /// <summary>
            /// <para>Source KB 归属类型（itemType=resource 时有值）：aliding_kb_doc / normal</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("sourceKind")]
            [Validation(Required=false)]
            public string SourceKind { get; set; }

            /// <summary>
            /// <para>目录下成功资源数（仅根目录列表时返回；下钻场景为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceReadyCount")]
            [Validation(Required=false)]
            public long? SourceReadyCount { get; set; }

            /// <summary>
            /// <para>资源状态（itemType=resource 时有值；本接口固定按 READY 过滤）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("sourceStatus")]
            [Validation(Required=false)]
            public string SourceStatus { get; set; }

            /// <summary>
            /// <para>目录下资源总数（含子目录，仅根目录列表时返回；下钻场景为 null）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceTotalCount")]
            [Validation(Required=false)]
            public long? SourceTotalCount { get; set; }

            /// <summary>
            /// <para>资源类型（itemType=resource 时有值）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
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
        /// <para>总数（不分页前的命中行数）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

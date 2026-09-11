// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListGraphSchemasResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>租户下 active 图谱摘要列表</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListGraphSchemasResponseBodyItems> Items { get; set; }
        public class ListGraphSchemasResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>active Schema 版本</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0</para>
            /// </summary>
            [NameInMap("activeVersion")]
            [Validation(Required=false)]
            public string ActiveVersion { get; set; }

            /// <summary>
            /// <para>业务说明，未设置时为空字符串</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户域语义图谱</para>
            /// </summary>
            [NameInMap("businessProfile")]
            [Validation(Required=false)]
            public string BusinessProfile { get; set; }

            /// <summary>
            /// <para>图谱展示名，空值时兜底 graphName</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRM 图谱</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>图谱名称</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm_graph</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>图谱状态：PUBLISHED / DEVELOPING（当前用户有活动草稿）/ PUBLISHING（当前用户发布中）</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("graphStatus")]
            [Validation(Required=false)]
            public string GraphStatus { get; set; }

            /// <summary>
            /// <para>当前调用者视角是否存在个人活动草稿；部署/系统级 Token 恒 false</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("hasDraft")]
            [Validation(Required=false)]
            public bool? HasDraft { get; set; }

            /// <summary>
            /// <para>是否为租户默认图谱</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>object_type 数量，解析失败兜底 0</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("objectTypeCount")]
            [Validation(Required=false)]
            public long? ObjectTypeCount { get; set; }

            /// <summary>
            /// <para>relation 数量，解析失败兜底 0</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("relationCount")]
            [Validation(Required=false)]
            public long? RelationCount { get; set; }

            /// <summary>
            /// <para>语义标签列表，未配置时为空数组</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("semanticTags")]
            [Validation(Required=false)]
            public List<string> SemanticTags { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

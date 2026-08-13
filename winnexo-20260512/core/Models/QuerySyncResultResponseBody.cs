// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QuerySyncResultResponseBody : TeaModel {
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
        /// <para>任务完成时间（ISO 8601）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>企业标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCorpId</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>部门同步统计（完成时有值）</para>
        /// </summary>
        [NameInMap("deptStats")]
        [Validation(Required=false)]
        public QuerySyncResultResponseBodyDeptStats DeptStats { get; set; }
        public class QuerySyncResultResponseBodyDeptStats : TeaModel {
            /// <summary>
            /// <para>新增的用户组数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>标记删除的用户组数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public long? Deleted { get; set; }

            /// <summary>
            /// <para>移动的用户组数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("moved")]
            [Validation(Required=false)]
            public long? Moved { get; set; }

            /// <summary>
            /// <para>更名的用户组数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("renamed")]
            [Validation(Required=false)]
            public long? Renamed { get; set; }

            /// <summary>
            /// <para>跳过的用户组数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("skipped")]
            [Validation(Required=false)]
            public long? Skipped { get; set; }

            /// <summary>
            /// <para>外部部门总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalExternal")]
            [Validation(Required=false)]
            public long? TotalExternal { get; set; }

        }

        /// <summary>
        /// <para>执行时长（秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("durationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// <para>错误信息（失败时有值）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>成员同步统计（syncMembers=true 且完成时有值）</para>
        /// </summary>
        [NameInMap("memberStats")]
        [Validation(Required=false)]
        public QuerySyncResultResponseBodyMemberStats MemberStats { get; set; }
        public class QuerySyncResultResponseBodyMemberStats : TeaModel {
            /// <summary>
            /// <para>失败的成员数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failed")]
            [Validation(Required=false)]
            public long? Failed { get; set; }

            /// <summary>
            /// <para>新增的成员关系数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("relationshipAdded")]
            [Validation(Required=false)]
            public long? RelationshipAdded { get; set; }

            /// <summary>
            /// <para>移除的成员关系数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("relationshipRemoved")]
            [Validation(Required=false)]
            public long? RelationshipRemoved { get; set; }

            /// <summary>
            /// <para>外部成员总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalExternal")]
            [Validation(Required=false)]
            public long? TotalExternal { get; set; }

            /// <summary>
            /// <para>未变更的成员关系数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("unchanged")]
            [Validation(Required=false)]
            public long? Unchanged { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>平台类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("platformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

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
        /// <para>任务开始执行时间（ISO 8601）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>任务状态: PENDING / RUNNING / COMPLETED / FAILED / TIMEOUT / CANCELED</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>任务提交时间（ISO 8601）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("submittedAt")]
        [Validation(Required=false)]
        public string SubmittedAt { get; set; }

        /// <summary>
        /// <para>执行摘要（人可读）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>任务 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}

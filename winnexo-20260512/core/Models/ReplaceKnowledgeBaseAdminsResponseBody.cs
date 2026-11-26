// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ReplaceKnowledgeBaseAdminsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>知识库创建者</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public ReplaceKnowledgeBaseAdminsResponseBodyCreator Creator { get; set; }
        public class ReplaceKnowledgeBaseAdminsResponseBodyCreator : TeaModel {
            /// <summary>
            /// <para>是否为不可移除的创建者</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("immutable")]
            [Validation(Required=false)]
            public bool? Immutable { get; set; }

            /// <summary>
            /// <para>用户 ID 或用户组 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("principalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>主体显示名称，无法解析时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("principalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>主体类型：USER 或 USER_GROUP</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("principalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>权限来源：CREATOR 或 DIRECT</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATOR</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>已配置的知识库根目录业务 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb_001</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>用户组展开和去重后的有效审批人</para>
        /// </summary>
        [NameInMap("effectiveApprovers")]
        [Validation(Required=false)]
        public List<ReplaceKnowledgeBaseAdminsResponseBodyEffectiveApprovers> EffectiveApprovers { get; set; }
        public class ReplaceKnowledgeBaseAdminsResponseBodyEffectiveApprovers : TeaModel {
            /// <summary>
            /// <para>产生该审批权限的主体 ID 列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;10001&quot;,&quot;group-1&quot;]</para>
            /// </summary>
            [NameInMap("sourcePrincipalIds")]
            [Validation(Required=false)]
            public List<string> SourcePrincipalIds { get; set; }

            /// <summary>
            /// <para>有效审批用户 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>租户内显示名称，无法解析时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
        /// <para>配置完成后的管理员主体列表，包含创建者</para>
        /// </summary>
        [NameInMap("principals")]
        [Validation(Required=false)]
        public List<ReplaceKnowledgeBaseAdminsResponseBodyPrincipals> Principals { get; set; }
        public class ReplaceKnowledgeBaseAdminsResponseBodyPrincipals : TeaModel {
            /// <summary>
            /// <para>是否为不可移除的创建者</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("immutable")]
            [Validation(Required=false)]
            public bool? Immutable { get; set; }

            /// <summary>
            /// <para>用户 ID 或用户组 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("principalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>主体显示名称，无法解析时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("principalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>主体类型：USER 或 USER_GROUP</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("principalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            /// <summary>
            /// <para>权限来源：CREATOR 或 DIRECT</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATOR</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

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

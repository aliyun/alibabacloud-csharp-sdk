// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetMemoryDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为 200，失败时为对应错误码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>自动拾取记忆的分组列表；无自动记忆时为空数组</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;user&quot;,&quot;items&quot;:[{&quot;id&quot;:&quot;user/example.md&quot;,&quot;title&quot;:&quot;示例偏好&quot;,&quot;content&quot;:&quot;喜欢简洁的回答&quot;,&quot;description&quot;:&quot;来自近期会话的偏好总结&quot;}],&quot;gmtModified&quot;:1720000000}]</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<GetMemoryDetailResponseBodyGroups> Groups { get; set; }
        public class GetMemoryDetailResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>该分组最近修改时间，Unix 秒级时间戳；无文件时为 null</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720000000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>该类型下的自动记忆条目列表；没有条目时为空数组</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;user/example.md&quot;,&quot;title&quot;:&quot;示例偏好&quot;,&quot;content&quot;:&quot;喜欢简洁的回答&quot;,&quot;description&quot;:&quot;来自近期会话的偏好总结&quot;}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetMemoryDetailResponseBodyGroupsItems> Items { get; set; }
            public class GetMemoryDetailResponseBodyGroupsItems : TeaModel {
                /// <summary>
                /// <para>自动记忆正文，不包含 YAML frontmatter</para>
                /// 
                /// <b>Example:</b>
                /// <para>喜欢简洁的回答</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>自动记忆的附加描述；没有时为空字符串</para>
                /// 
                /// <b>Example:</b>
                /// <para>来自近期会话的偏好总结</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>自动记忆条目的唯一标识，为相对 OSS 路径</para>
                /// 
                /// <b>Example:</b>
                /// <para>user/example.md</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>自动记忆标题，来自文件元数据或文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例偏好</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>自动记忆类型：user、feedback、reference 或 project</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>错误描述；成功时为空字符串，失败时返回具体原因</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前用户不是群组 cg_12345 的活跃成员</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>手动添加的记忆，来自 profile.md；包含完整内容、存在状态和修改时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;示例手动记忆&quot;,&quot;exists&quot;:true,&quot;gmtModified&quot;:1720000000}</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public GetMemoryDetailResponseBodyProfile Profile { get; set; }
        public class GetMemoryDetailResponseBodyProfile : TeaModel {
            /// <summary>
            /// <para>手动记忆的完整正文；未保存过时为空字符串</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例手动记忆</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>profile.md 是否存在；未保存过时为 false</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("exists")]
            [Validation(Required=false)]
            public bool? Exists { get; set; }

            /// <summary>
            /// <para>profile.md 最近修改时间，Unix 秒级时间戳；文件不存在或无法取得元数据时为 null</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720000000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

        }

        /// <summary>
        /// <para>请求追踪 ID，用于定位本次调用</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

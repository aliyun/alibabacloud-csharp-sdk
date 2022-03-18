// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoriesResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRepositoriesResponseBodyResult> Result { get; set; }
        public class ListRepositoriesResponseBodyResult : TeaModel {
            /// <summary>
            /// 代码库Id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 当前用户在该代码库上的权限类型
            /// </summary>
            [NameInMap("accessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }

            /// <summary>
            /// 代码库是否归档
            /// </summary>
            [NameInMap("archive")]
            [Validation(Required=false)]
            public bool? Archive { get; set; }

            /// <summary>
            /// 头像地址
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// 代码库描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 代码库导入状态
            /// </summary>
            [NameInMap("importStatus")]
            [Validation(Required=false)]
            public string ImportStatus { get; set; }

            /// <summary>
            /// 最后活跃时间
            /// </summary>
            [NameInMap("lastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }

            /// <summary>
            /// 代码库名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 代码库完整名称（含完整组名称）
            /// </summary>
            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            /// <summary>
            /// 上级路径的id
            /// </summary>
            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public long? NamespaceId { get; set; }

            /// <summary>
            /// 代码库路径
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// 代码库完整路径（含完整组路径）
            /// </summary>
            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            /// <summary>
            /// 是否被收藏
            /// </summary>
            [NameInMap("star")]
            [Validation(Required=false)]
            public bool? Star { get; set; }

            /// <summary>
            /// 被收藏的数量
            /// </summary>
            [NameInMap("starCount")]
            [Validation(Required=false)]
            public long? StarCount { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// 可见性;0标识私有的/10标识企业内公开
            /// </summary>
            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }

            /// <summary>
            /// 页面访问时的URL
            /// </summary>
            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

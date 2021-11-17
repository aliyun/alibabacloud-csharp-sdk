// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// 代码来源URL（当前仅支持云效 Codeup 来源）
        /// </summary>
        [NameInMap("codeUrl")]
        [Validation(Required=false)]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 代码版本，支持 commitSHA、分支、标签
        /// </summary>
        [NameInMap("codeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        /// <summary>
        /// 打开空间默认打开的文件相对路径
        /// </summary>
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 请求来源（用于统计，云产品集成时需要传入）
        /// </summary>
        [NameInMap("requestFrom")]
        [Validation(Required=false)]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 资源标识，提供给非标代码源作为空间复用的唯一标识
        /// </summary>
        [NameInMap("resourceIdentifier")]
        [Validation(Required=false)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// 工作空间复用标识，按照"用户+技术栈+代码地址+版本"进行复用 true - 复用 false - 不复用，每次均为新创建
        /// </summary>
        [NameInMap("reuse")]
        [Validation(Required=false)]
        public bool? Reuse { get; set; }

        /// <summary>
        /// 技术栈
        /// </summary>
        [NameInMap("workspaceTemplate")]
        [Validation(Required=false)]
        public string WorkspaceTemplate { get; set; }

    }

}

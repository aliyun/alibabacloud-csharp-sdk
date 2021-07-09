// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UpdateWorkspaceRequest : TeaModel {
        /// <summary>
        /// 工作空间名称
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        /// <summary>
        /// 工作空间描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 工作空间OSS工作路径
        /// </summary>
        [NameInMap("OssRoot")]
        [Validation(Required=false)]
        public string OssRoot { get; set; }

        /// <summary>
        /// 工作空间内任务生命周期
        /// </summary>
        [NameInMap("JobLifecycle")]
        [Validation(Required=false)]
        public int? JobLifecycle { get; set; }

        /// <summary>
        /// 工作空间内Ram角色
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// 工作空间标签
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

    }

}

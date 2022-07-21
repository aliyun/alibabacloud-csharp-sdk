// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Workspace : TeaModel {
        /// <summary>
        /// 创建者
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// 成员列表
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<Member> Members { get; set; }

        /// <summary>
        /// 资源配额列表
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<Quota> Quotas { get; set; }

        /// <summary>
        /// 资源总量
        /// </summary>
        [NameInMap("TotalResources")]
        [Validation(Required=false)]
        public Resources TotalResources { get; set; }

        /// <summary>
        /// 管理员列表
        /// </summary>
        [NameInMap("WorkspaceAdmins")]
        [Validation(Required=false)]
        public List<Member> WorkspaceAdmins { get; set; }

        /// <summary>
        /// 工作空间id
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}

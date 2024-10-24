// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Workspace : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ken</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<Member> Members { get; set; }

        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<Quota> Quotas { get; set; }

        [NameInMap("TotalResources")]
        [Validation(Required=false)]
        public Resources TotalResources { get; set; }

        [NameInMap("WorkspaceAdmins")]
        [Validation(Required=false)]
        public List<Member> WorkspaceAdmins { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ws-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}

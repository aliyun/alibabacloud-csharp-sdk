// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateChangeRequestResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sn123</para>
        /// </summary>
        [NameInMap("appCodeRepoSn")]
        [Validation(Required=false)]
        public string AppCodeRepoSn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>app-name</para>
        /// </summary>
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoDeleteBranchWhenEnd")]
        [Validation(Required=false)]
        public bool? AutoDeleteBranchWhenEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hotfix/20240524</para>
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>create-account-123</para>
        /// </summary>
        [NameInMap("creatorAccountId")]
        [Validation(Required=false)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>create-id-123</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("originBranch")]
        [Validation(Required=false)]
        public string OriginBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>revision-123</para>
        /// </summary>
        [NameInMap("originBranchRevisionSha")]
        [Validation(Required=false)]
        public string OriginBranchRevisionSha { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>account-id-123</para>
        /// </summary>
        [NameInMap("ownerAccountId")]
        [Validation(Required=false)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>owner-id-123</para>
        /// </summary>
        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ce51b31b996246ecaf874736838360b2</para>
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEVELOPING</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APP</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

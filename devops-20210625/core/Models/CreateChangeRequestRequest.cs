// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateChangeRequestRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sn123</para>
        /// </summary>
        [NameInMap("appCodeRepoSn")]
        [Validation(Required=false)]
        public string AppCodeRepoSn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoDeleteBranchWhenEnd")]
        [Validation(Required=false)]
        public bool? AutoDeleteBranchWhenEnd { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hotfix/20240524</para>
        /// </summary>
        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("createBranch")]
        [Validation(Required=false)]
        public bool? CreateBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1332695887xxxxxx</para>
        /// </summary>
        [NameInMap("ownerAccountId")]
        [Validation(Required=false)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66c0c9fffeb86b450c199fcd</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}

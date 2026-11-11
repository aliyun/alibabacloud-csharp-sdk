// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CmsV1MigrationAdmission : TeaModel {
        /// <summary>
        /// <para>The real-time new migration eligibility evaluated for the current target primary account, which does not replace RAM, account ownership, or workspace validations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("newMigrationAllowed")]
        [Validation(Required=false)]
        public bool? NewMigrationAllowed { get; set; }

        /// <summary>
        /// <para>The summary of the normalized policy, which excludes the UID list and is not an authorization credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03ac8b5b92cb9c2675119d64c31d2520c069647aa9b88979df1bb115472c02b4</para>
        /// </summary>
        [NameInMap("policyRevision")]
        [Validation(Required=false)]
        public string PolicyRevision { get; set; }

        /// <summary>
        /// <para>The reason why the new migration is denied. CMSV1_MIGRATION_NOT_ADMITTED indicates that the migration is not admitted, and CMSV1_MIGRATION_POLICY_UNAVAILABLE indicates that the policy is unavailable. Historical tasks remain queryable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CMSV1_MIGRATION_NOT_ADMITTED</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class RestoreBranchRequest : TeaModel {
        /// <summary>
        /// <para>The branch ID that uniquely identifies a Supabase branch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-xxxx</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>The client idempotency token that ensures the idempotence of retry requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The backup branch name. If specified, automatic creation of a backup branch is performed before recovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backup-main</para>
        /// </summary>
        [NameInMap("PreserveUnderName")]
        [Validation(Required=false)]
        public string PreserveUnderName { get; set; }

        /// <summary>
        /// <para>The Supabase project ID associated with the primary branch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required when you create a primary branch. When you create a sub-branch, the region is inherited from the primary branch by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the source branch from which to recover.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-main</para>
        /// </summary>
        [NameInMap("SourceBranchId")]
        [Validation(Required=false)]
        public string SourceBranchId { get; set; }

        /// <summary>
        /// <para>The LSN of the source branch to recover to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/3522648</para>
        /// </summary>
        [NameInMap("SourceBranchLsn")]
        [Validation(Required=false)]
        public string SourceBranchLsn { get; set; }

        /// <summary>
        /// <para>The point in time of the source branch to recover to. The value must be within the recoverable time window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("SourceBranchTimestamp")]
        [Validation(Required=false)]
        public string SourceBranchTimestamp { get; set; }

    }

}

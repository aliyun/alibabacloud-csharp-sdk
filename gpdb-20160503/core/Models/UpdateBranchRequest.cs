// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpdateBranchRequest : TeaModel {
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
        /// <para>The branch name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>Specifies whether to clear the branch expiration time.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Clears ExpiresAt.</description></item>
        /// <item><description>false: Does not clear ExpiresAt.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the existing expiration time remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClearExpiresAt")]
        [Validation(Required=false)]
        public bool? ClearExpiresAt { get; set; }

        /// <summary>
        /// <para>The branch description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test branch</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the branch automatically expires and is deleted. The value is in ISO 8601 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The Supabase project ID that corresponds to the primary branch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spb-xxxx</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable branch protection.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Branch protection is enabled.</description></item>
        /// <item><description>false: Branch protection is disabled. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Protected")]
        [Validation(Required=false)]
        public bool? Protected { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required when you create a primary branch. When you create a sub-branch, the region of the primary branch is inherited by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of branch tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateBranchRequestTag> Tag { get; set; }
        public class UpdateBranchRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

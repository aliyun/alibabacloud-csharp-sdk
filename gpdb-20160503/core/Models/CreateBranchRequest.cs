// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateBranchRequest : TeaModel {
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
        /// <para>The client idempotency token. This token ensures the idempotence of retry requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The time at which the branch automatically expires and is deleted. The value is in ISO 8601 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// <para>The initialization source of the branch.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ParentData: copies the schema and data from the parent branch. This is the default value.</description></item>
        /// <item><description>SchemaOnly: copies only the schema structure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ParentData</para>
        /// </summary>
        [NameInMap("InitSource")]
        [Validation(Required=false)]
        public string InitSource { get; set; }

        /// <summary>
        /// <para>The parent branch ID. This parameter specifies the parent branch for the new branch or query condition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-main</para>
        /// </summary>
        [NameInMap("ParentBranchId")]
        [Validation(Required=false)]
        public string ParentBranchId { get; set; }

        /// <summary>
        /// <para>The log sequence number (LSN) from the parent branch at which the branch is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/3522648</para>
        /// </summary>
        [NameInMap("ParentLsn")]
        [Validation(Required=false)]
        public string ParentLsn { get; set; }

        /// <summary>
        /// <para>The point in time for data synchronization from the parent branch when creating the branch. The value is in ISO 8601 UTC format.</para>
        /// <para>Default value: the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-08T09:11:12Z</para>
        /// </summary>
        [NameInMap("ParentTimestamp")]
        [Validation(Required=false)]
        public string ParentTimestamp { get; set; }

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
        /// <item><description>true: Enables branch protection.</description></item>
        /// <item><description>false: Disables branch protection. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Protected")]
        [Validation(Required=false)]
        public bool? Protected { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required when you create a primary branch. When you create a child branch, the region is inherited from the primary branch by default.</para>
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
        public List<CreateBranchRequestTag> Tag { get; set; }
        public class CreateBranchRequestTag : TeaModel {
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

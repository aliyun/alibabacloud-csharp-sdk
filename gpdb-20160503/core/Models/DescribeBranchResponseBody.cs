// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeBranchResponseBody : TeaModel {
        /// <summary>
        /// <para>The branch list. Each element represents a Supabase branch.</para>
        /// </summary>
        [NameInMap("Branch")]
        [Validation(Required=false)]
        public DescribeBranchResponseBodyBranch Branch { get; set; }
        public class DescribeBranchResponseBodyBranch : TeaModel {
            /// <summary>
            /// <para>The branch ID, which uniquely identifies a Supabase branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-xxxx</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public string BranchId { get; set; }

            /// <summary>
            /// <para>The branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            /// <summary>
            /// <para>The connection information of the compute node associated with the branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>postgresql://user:password@host:5432/db</para>
            /// </summary>
            [NameInMap("ComputeEndpoint")]
            [Validation(Required=false)]
            public string ComputeEndpoint { get; set; }

            /// <summary>
            /// <para>The time when the branch was created, in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-08T09:11:12Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// <para>The time when the branch expires and is automatically deleted, in ISO 8601 UTC format.</para>
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
            /// <item><description>ParentData: Copies the schema and data from the parent branch. This is the default value.</description></item>
            /// <item><description>SchemaOnly: Copies only the schema structure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ParentData</para>
            /// </summary>
            [NameInMap("InitSource")]
            [Validation(Required=false)]
            public string InitSource { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The parent branch ID, which specifies the parent branch of a new branch or a query condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-main</para>
            /// </summary>
            [NameInMap("ParentBranchId")]
            [Validation(Required=false)]
            public string ParentBranchId { get; set; }

            /// <summary>
            /// <para>The parent branch name. This value is empty or displayed as - for the primary branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("ParentBranchName")]
            [Validation(Required=false)]
            public string ParentBranchName { get; set; }

            /// <summary>
            /// <para>The Log Sequence Number (LSN) of the parent branch at the time this branch was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0/3522648</para>
            /// </summary>
            [NameInMap("ParentLSN")]
            [Validation(Required=false)]
            public string ParentLSN { get; set; }

            /// <summary>
            /// <para>The data synchronization point in time selected from the parent branch when this branch was created, in ISO 8601 UTC format.</para>
            /// <para>Note:</para>
            /// <list type="bullet">
            /// <item><description>For child branches, this value indicates the point in time of the parent branch selected during creation.</description></item>
            /// <item><description>If no parent branch exists, the value 1970-01-01T00:00:00.000Z is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-08T09:11:12Z</para>
            /// </summary>
            [NameInMap("ParentTimestamp")]
            [Validation(Required=false)]
            public string ParentTimestamp { get; set; }

            /// <summary>
            /// <para>The Supabase project ID that corresponds to the primary branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spb-xxxx</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether branch protection is enabled. A value of true indicates that branch protection is enabled. A value of false indicates that branch protection is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Protected")]
            [Validation(Required=false)]
            public bool? Protected { get; set; }

            /// <summary>
            /// <para>The service type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Supabase: Supabase service.</description></item>
            /// <item><description>Memory: Memory service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Supabase</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The branch status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of branch tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeBranchResponseBodyBranchTags> Tags { get; set; }
            public class DescribeBranchResponseBodyBranchTags : TeaModel {
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

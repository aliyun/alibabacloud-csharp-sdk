// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of lifecycle management policy information.</para>
        /// </summary>
        [NameInMap("LifecyclePolicies")]
        [Validation(Required=false)]
        public List<DescribeLifecyclePoliciesResponseBodyLifecyclePolicies> LifecyclePolicies { get; set; }
        public class DescribeLifecyclePoliciesResponseBodyLifecyclePolicies : TeaModel {
            /// <summary>
            /// <para>The time when the lifecycle management policy was created.</para>
            /// <para>The time follows the ISO 8601 standard in the format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31a8e4****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The ID of the lifecycle policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lc-xxx</para>
            /// </summary>
            [NameInMap("LifecyclePolicyId")]
            [Validation(Required=false)]
            public string LifecyclePolicyId { get; set; }

            /// <summary>
            /// <para>The lifecycle management policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lifecyclepolicy_01</para>
            /// </summary>
            [NameInMap("LifecyclePolicyName")]
            [Validation(Required=false)]
            public string LifecyclePolicyName { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("LifecyclePolicyType")]
            [Validation(Required=false)]
            public string LifecyclePolicyType { get; set; }

            /// <summary>
            /// <para>The management rule associated with the lifecycle management policy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT_ATIME_14: files not accessed in the last 14 days</description></item>
            /// <item><description>DEFAULT_ATIME_30: files not accessed in the last 30 days</description></item>
            /// <item><description>DEFAULT_ATIME_60: files not accessed in the last 60 days</description></item>
            /// <item><description>DEFAULT_ATIME_90: files not accessed in the last 90 days.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_ATIME_14</para>
            /// </summary>
            [NameInMap("LifecycleRuleName")]
            [Validation(Required=false)]
            public string LifecycleRuleName { get; set; }

            /// <summary>
            /// <para>The absolute path of the single directory configured in the lifecycle management policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/pathway/to/folder</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The list of absolute paths of multiple directories configured in the lifecycle management policy.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The data retrieval rules for files.</para>
            /// </summary>
            [NameInMap("RetrieveRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePoliciesResponseBodyLifecyclePoliciesRetrieveRules> RetrieveRules { get; set; }
            public class DescribeLifecyclePoliciesResponseBodyLifecyclePoliciesRetrieveRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the retrieval rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RetrieveType</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The threshold of the retrieval rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// <para>The storage class type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InfrequentAccess: IA storage class.</description></item>
            /// <item><description>Archive: Archive storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The data transit rules for files.</para>
            /// </summary>
            [NameInMap("TransitRules")]
            [Validation(Required=false)]
            public List<DescribeLifecyclePoliciesResponseBodyLifecyclePoliciesTransitRules> TransitRules { get; set; }
            public class DescribeLifecyclePoliciesResponseBodyLifecyclePoliciesTransitRules : TeaModel {
                /// <summary>
                /// <para>The attribute of the transit rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Atime</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The threshold of the transit rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of lifecycle management policies on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of lifecycle management policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

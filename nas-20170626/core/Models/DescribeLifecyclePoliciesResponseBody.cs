// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried lifecycle policies.</para>
        /// </summary>
        [NameInMap("LifecyclePolicies")]
        [Validation(Required=false)]
        public List<DescribeLifecyclePoliciesResponseBodyLifecyclePolicies> LifecyclePolicies { get; set; }
        public class DescribeLifecyclePoliciesResponseBodyLifecyclePolicies : TeaModel {
            /// <summary>
            /// <para>The time when the lifecycle policy was created.</para>
            /// <para>The time follows the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EnableLifecycle")]
            [Validation(Required=false)]
            public bool? EnableLifecycle { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31a8e4****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("FsetIds")]
            [Validation(Required=false)]
            public List<string> FsetIds { get; set; }

            /// <summary>
            /// <para>The name of the lifecycle policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lifecyclepolicy_01</para>
            /// </summary>
            [NameInMap("LifecyclePolicyName")]
            [Validation(Required=false)]
            public string LifecyclePolicyName { get; set; }

            /// <summary>
            /// <para>The management rule that is associated with the lifecycle policy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT_ATIME_14: Files that are not accessed in the last 14 days are dumped to the IA storage medium.</description></item>
            /// <item><description>DEFAULT_ATIME_30: Files that are not accessed in the last 30 days are dumped to the IA storage medium.</description></item>
            /// <item><description>DEFAULT_ATIME_60: Files that are not accessed in the last 60 days are dumped to the IA storage medium.</description></item>
            /// <item><description>DEFAULT_ATIME_90: Files that are not accessed in the last 90 days are dumped to the IA storage medium.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_ATIME_14</para>
            /// </summary>
            [NameInMap("LifecycleRuleName")]
            [Validation(Required=false)]
            public string LifecycleRuleName { get; set; }

            [NameInMap("LifecycleRuleType")]
            [Validation(Required=false)]
            public string LifecycleRuleType { get; set; }

            /// <summary>
            /// <para>The absolute path of a directory with which the lifecycle policy is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/pathway/to/folder</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The absolute paths to multiple directories associated with the lifecycle policy.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage type of the data that is dumped to the IA storage medium.</para>
            /// <para>Default value: InfrequentAccess (IA).</para>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The total number of lifecycle policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

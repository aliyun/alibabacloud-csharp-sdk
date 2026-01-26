// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The description of the lifecycle policy.</para>
        /// <para>Format: The name must be 3 to 64 characters in length and must start with a letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> Only CPFS for Lingjun supports this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle policy. The name must be 3 to 64 characters in length and must start with a letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> Required for General-purpose NAS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclepolicy_01</para>
        /// </summary>
        [NameInMap("LifecyclePolicyName")]
        [Validation(Required=false)]
        public string LifecyclePolicyName { get; set; }

        /// <summary>
        /// <para>The policy type.</para>
        /// <list type="bullet">
        /// <item><description>Auto (default): The job is automatically triggered.</description></item>
        /// <item><description>OnDemand: On-demand execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LifecyclePolicyType")]
        [Validation(Required=false)]
        public string LifecyclePolicyType { get; set; }

        /// <summary>
        /// <para>The management rule associated with the lifecycle policy. Only General-purpose NAS supports this parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT_ATIME_14: Files not accessed for 14 days.</description></item>
        /// <item><description>DEFAULT_ATIME_30: Files not accessed for 30 days.</description></item>
        /// <item><description>DEFAULT_ATIME_60: Files not accessed for 60 days.</description></item>
        /// <item><description>DEFAULT_ATIME_90: Files not accessed for 90 days.</description></item>
        /// <item><description>DEFAULT_ATIME_180: Files not accessed for 180 days. DEFAULT_ATIME_180 is supported only when the StorageType parameter is set to Archive.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If an IA policy already exists for the directory, the new archive policy must have a longer transition period.</para>
        /// </description></item>
        /// <item><description><para>Only General-purpose NAS supports this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_ATIME_14</para>
        /// </summary>
        [NameInMap("LifecycleRuleName")]
        [Validation(Required=false)]
        public string LifecycleRuleName { get; set; }

        /// <summary>
        /// <para>The absolute path of the directory associated with the lifecycle policy. Only General-purpose NAS supports this parameter.</para>
        /// <list type="bullet">
        /// <item><description>Single value only. The path must start with a forward slash (/) and must be a path that exists in the mount target.</description></item>
        /// </list>
        /// <remarks>
        /// <para> We recommend configuring the Paths.N parameter so that you can associate the policy with multiple directories at a time.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Path and Paths are mutually exclusive. You must specify one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/pathway/to/folder</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The absolute paths of the directories associated with the lifecycle policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;/path1&quot;, &quot;/path2&quot;</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// <para>The file data retrieval rule. Only one rule can be configured.</para>
        /// <remarks>
        /// <para> Only CPFS for Lingjun supports this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RetrieveRules")]
        [Validation(Required=false)]
        public List<CreateLifecyclePolicyRequestRetrieveRules> RetrieveRules { get; set; }
        public class CreateLifecyclePolicyRequestRetrieveRules : TeaModel {
            /// <summary>
            /// <para>The attribute of the rule. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>RetrieveType: the retrieval method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RetrieveType</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The threshold of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RetrieveType</para>
            /// <list type="bullet">
            /// <item><description>AfterVisit: Supported when LifecyclePolicyType is Auto. Represents a best-effort recall on access.</description></item>
            /// <item><description>All: Supported when LifecyclePolicyType is OnDemand. Represents retrieving all data.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

        }

        /// <summary>
        /// <para>The storage class.</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess: the Infrequent Access (IA) storage class.</description></item>
        /// <item><description>Archive: the Archive storage class.</description></item>
        /// </list>
        /// <remarks>
        /// <para> General-purpose NAS supports InfrequentAccess and Archive. CPFS for Lingjun only supports InfrequentAccess.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The data transition rule. Only one rule can be configured.</para>
        /// <remarks>
        /// <para> Supported only for CPFS for Lingjun file systems with LifecyclePolicyType set to Auto.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRules")]
        [Validation(Required=false)]
        public List<CreateLifecyclePolicyRequestTransitRules> TransitRules { get; set; }
        public class CreateLifecyclePolicyRequestTransitRules : TeaModel {
            /// <summary>
            /// <para>Attribute of the rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Atime: the access time of the file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Atime</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>Threshold for the rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If Attribute is set to Atime, this value represents the number of days since the file was last accessed. Valid values: [1, 365].</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

        }

    }

}

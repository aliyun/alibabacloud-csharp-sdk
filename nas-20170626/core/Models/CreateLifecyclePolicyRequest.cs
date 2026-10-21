// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The file data expiration and deletion rules. You can configure up to 1 rule.</para>
        /// </summary>
        [NameInMap("DeleteRules")]
        [Validation(Required=false)]
        public List<CreateLifecyclePolicyRequestDeleteRules> DeleteRules { get; set; }
        public class CreateLifecyclePolicyRequestDeleteRules : TeaModel {
            /// <summary>
            /// <para>The attribute of the rule.</para>
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
            /// <para>The threshold of the rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When Attribute is set to Atime, the value indicates the number of days a file has not been accessed. Valid values: 1 to 365.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

        }

        /// <summary>
        /// <para>The description of the lifecycle policy.</para>
        /// <para>Format:
        /// The description must be 3 to 64 characters in length, and must start with a letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>This parameter is supported only by CPFS for Lingjun.</para>
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
        /// <para>The lifecycle management policy name. The name must be 3 to 64 characters in length, and must start with an uppercase letter or a lowercase letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>This parameter is required for General-purpose NAS, but not required for CPFS for Lingjun.</para>
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
        /// <item><description>Auto (default): automatic execution.</description></item>
        /// <item><description>OnDemand: on-demand execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LifecyclePolicyType")]
        [Validation(Required=false)]
        public string LifecyclePolicyType { get; set; }

        /// <summary>
        /// <para>The management rule associated with the lifecycle management policy. This parameter is supported only by General-purpose NAS.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT_ATIME_14: files that have not been accessed for 14 days.</description></item>
        /// <item><description>DEFAULT_ATIME_30: files that have not been accessed for 30 days.</description></item>
        /// <item><description>DEFAULT_ATIME_60: files that have not been accessed for 60 days.</description></item>
        /// <item><description>DEFAULT_ATIME_90: files that have not been accessed for 90 days.</description></item>
        /// <item><description>DEFAULT_ATIME_180: files that have not been accessed for 180 days. DEFAULT_ATIME_180 is supported only when StorageType is set to Archive.<remarks>
        /// <list type="bullet">
        /// <item><description>If an IA storage class policy is already configured for the directory, the time threshold for the archive storage class policy must be longer than that of the IA storage class policy when you configure the archive storage class policy.</description></item>
        /// <item><description>This parameter is supported only by General-purpose NAS.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The absolute path of the directory associated with the lifecycle management policy. This parameter is supported only by General-purpose NAS.</para>
        /// <list type="bullet">
        /// <item><description>General-purpose NAS supports associating only a single directory. The path must start with a forward slash (/) and must be an existing path in the mount target.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only by General-purpose NAS. For General-purpose NAS, configure Paths.N to associate multiple directories at the same time.</para>
        /// <list type="bullet">
        /// <item><description>You must specify either Path or Paths, but not both.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/pathway/to/folder</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The absolute paths of the directories associated with the lifecycle management policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;/path1&quot;, &quot;/path2&quot;</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// <para>The file data retrieval rules. You can configure up to 1 rule.</para>
        /// <remarks>
        /// <para>This parameter is supported only by CPFS for Lingjun file systems.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When LifecyclePolicyType is set to OnDemand, you must specify at least one of the active transition rules (TransitRules) and retrieval rules (RetrieveRules).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RetrieveRules")]
        [Validation(Required=false)]
        public List<CreateLifecyclePolicyRequestRetrieveRules> RetrieveRules { get; set; }
        public class CreateLifecyclePolicyRequestRetrieveRules : TeaModel {
            /// <summary>
            /// <para>The attribute of the rule. Valid values:</para>
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
            /// <item><description>RetrieveType<list type="bullet">
            /// <item><description>AfterVisit: supported when LifecyclePolicyType is set to Auto, which indicates best-effort recall on visit.</description></item>
            /// <item><description>All: supported when LifecyclePolicyType is set to OnDemand, which indicates retrieving all files.</description></item>
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
        /// <para>The tiered storage type.</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess: IA storage class.</description></item>
        /// <item><description>Archive: archive storage class.</description></item>
        /// </list>
        /// <remarks>
        /// <para>General-purpose NAS supports both InfrequentAccess and Archive. CPFS for Lingjun supports only InfrequentAccess.</para>
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
        /// <para>The file data transit rules. You can configure up to 1 rule.</para>
        /// <remarks>
        /// <para>This parameter is supported only when LifecyclePolicyType is set to Auto for CPFS for Lingjun file systems.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRules")]
        [Validation(Required=false)]
        public List<CreateLifecyclePolicyRequestTransitRules> TransitRules { get; set; }
        public class CreateLifecyclePolicyRequestTransitRules : TeaModel {
            /// <summary>
            /// <para>The attribute of the rule.</para>
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
            /// <para>The threshold of the rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When Attribute is set to Atime, the value indicates the number of days a file has not been accessed. Valid values: 0 to 365.</description></item>
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

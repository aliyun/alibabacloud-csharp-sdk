// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class UpdateLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The expiration and deletion rules for file data.</para>
        /// </summary>
        [NameInMap("DeleteRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestDeleteRules> DeleteRules { get; set; }
        public class UpdateLifecyclePolicyRequestDeleteRules : TeaModel {
            /// <summary>
            /// <para>The attribute of the rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Atime: the last access time of the file.</description></item>
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
            /// <item><description>If Attribute is set to Atime, the value indicates the number of days that a file has not been accessed. Valid values: 1 to 365.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

        }

        /// <summary>
        /// <para>The description of the lifecycle policy.</para>
        /// <para>Format:
        /// The description must be 3 to 64 characters in length. It must start with a letter and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>Supported only for CPFS for Lingjun.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Lifecycle policy description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the file system. The ID starts with bmcpfs-, such as bmcpfs-290w65p03ok64ya****. To use CPFS for Lingjun, you must first submit a ticket to apply for the service whitelist and then create the file system in the NAS console.</para>
        /// <remarks>
        /// <para>Supported only when LifecyclePolicyType is set to OnDemand in the lifecycle management policy of a CPFS for Lingjun file system.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64y*****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the lifecycle policy.</para>
        /// <remarks>
        /// <para>Required for CPFS for Lingjun file systems.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsp-bp1234567890ab****</para>
        /// </summary>
        [NameInMap("LifecyclePolicyId")]
        [Validation(Required=false)]
        public string LifecyclePolicyId { get; set; }

        /// <summary>
        /// <para>The absolute path of the directory associated with the lifecycle management policy. This parameter is required when FileSystemId starts with bmcpfs-.</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// <para>The data retrieval rules for files. You can configure up to one rule.</para>
        /// <remarks>
        /// <para>Supported only for CPFS for Lingjun file systems.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RetrieveRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestRetrieveRules> RetrieveRules { get; set; }
        public class UpdateLifecyclePolicyRequestRetrieveRules : TeaModel {
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
            /// <para>The threshold of the rule. Valid values for RetrieveType:</para>
            /// <list type="bullet">
            /// <item><description>AfterVisit: supported when LifecyclePolicyType is set to Auto. This value indicates best-effort recall on visit.</description></item>
            /// <item><description>All: supported when LifecyclePolicyType is set to OnDemand. This value indicates that all data is retrieved.</description></item>
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
        /// <para>The tiered storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess: IA storage class. This is the default value.</description></item>
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
        /// <para>The data transition rules for files. You can configure up to one rule.</para>
        /// <remarks>
        /// <para>Supported only when LifecyclePolicyType is set to Auto for a CPFS for Lingjun file system.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestTransitRules> TransitRules { get; set; }
        public class UpdateLifecyclePolicyRequestTransitRules : TeaModel {
            /// <summary>
            /// <para>The attribute of the rule.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Atime: the last access time of the file.</description></item>
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
            /// <item><description>If Attribute is set to Atime, the value indicates the number of days that a file has not been accessed. Valid values: 1 to 365.</description></item>
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

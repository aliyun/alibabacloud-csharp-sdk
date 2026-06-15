// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class UpdateLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The description of the lifecycle policy.</para>
        /// <para>The description must be 3 to 64 characters long and must start with a letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>This parameter is supported only for CPFS for AI file systems.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Lifecycle policy description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
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
        /// <para>This parameter is required for CPFS for AI file systems.</para>
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
        /// <para>The absolute paths of the directories to which the lifecycle policy applies.</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// <para>The retrieval rule for files. You can specify only one retrieval rule.</para>
        /// <remarks>
        /// <para>This parameter is supported only for CPFS for AI file systems.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RetrieveRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestRetrieveRules> RetrieveRules { get; set; }
        public class UpdateLifecyclePolicyRequestRetrieveRules : TeaModel {
            /// <summary>
            /// <para>The rule attribute. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>RetrieveType</c>: The retrieval method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RetrieveType</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The retrieval method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>Attribute</c> is set to <c>RetrieveType</c>:</para>
            /// <list type="bullet">
            /// <item><description><para><c>AfterVisit</c>: Retrieves data on a best-effort basis after a file is accessed. This value is valid only when <c>LifecyclePolicyType</c> is <c>Auto</c>.</para>
            /// </description></item>
            /// <item><description><para><c>All</c>: Retrieves all data. This value is valid only when <c>LifecyclePolicyType</c> is <c>OnDemand</c>.</para>
            /// </description></item>
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
        /// <para>The storage tier.</para>
        /// <list type="bullet">
        /// <item><description><para><c>InfrequentAccess</c>: The Infrequent Access storage tier. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>Archive</c>: The Archive storage tier.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The transition rule for files. You can specify only one transition rule.</para>
        /// <remarks>
        /// <para>This parameter is supported only for CPFS for AI file systems when <c>LifecyclePolicyType</c> is set to <c>Auto</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestTransitRules> TransitRules { get; set; }
        public class UpdateLifecyclePolicyRequestTransitRules : TeaModel {
            /// <summary>
            /// <para>The rule attribute.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>Atime</c>: The last access time of a file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Atime</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The rule threshold.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>If <c>Attribute</c> is set to <c>Atime</c>, this parameter specifies the number of days since a file was last accessed. The value must be between 1 and 365.</description></item>
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

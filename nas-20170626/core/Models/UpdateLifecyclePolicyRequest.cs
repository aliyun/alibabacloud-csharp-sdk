// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class UpdateLifecyclePolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Lifecycle policy description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64y*****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsp-bp1234567890ab****</para>
        /// </summary>
        [NameInMap("LifecyclePolicyId")]
        [Validation(Required=false)]
        public string LifecyclePolicyId { get; set; }

        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

        [NameInMap("RetrieveRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestRetrieveRules> RetrieveRules { get; set; }
        public class UpdateLifecyclePolicyRequestRetrieveRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>RetrieveType</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("TransitRules")]
        [Validation(Required=false)]
        public List<UpdateLifecyclePolicyRequestTransitRules> TransitRules { get; set; }
        public class UpdateLifecyclePolicyRequestTransitRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Atime</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

        }

    }

}

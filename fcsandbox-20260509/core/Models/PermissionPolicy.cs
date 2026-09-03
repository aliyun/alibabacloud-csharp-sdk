// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PermissionPolicy : TeaModel {
        /// <summary>
        /// <para>The allow policy.</para>
        /// </summary>
        [NameInMap("allow")]
        [Validation(Required=false)]
        public PermissionPolicyAllow Allow { get; set; }
        public class PermissionPolicyAllow : TeaModel {
            /// <summary>
            /// <para>The actions.</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

            /// <summary>
            /// <para>The capabilities.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

        }

        /// <summary>
        /// <para>catalog version</para>
        /// </summary>
        [NameInMap("catalogVersion")]
        [Validation(Required=false)]
        public long? CatalogVersion { get; set; }

        /// <summary>
        /// <para>The deny policy.</para>
        /// </summary>
        [NameInMap("deny")]
        [Validation(Required=false)]
        public PermissionPolicyDeny Deny { get; set; }
        public class PermissionPolicyDeny : TeaModel {
            /// <summary>
            /// <para>The actions.</para>
            /// </summary>
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

            /// <summary>
            /// <para>The capabilities.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

        }

        /// <summary>
        /// <para>schema version</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public long? SchemaVersion { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupCapabilityResponseBody : TeaModel {
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<ListResourceGroupCapabilityResponseBodyCapabilities> Capabilities { get; set; }
        public class ListResourceGroupCapabilityResponseBodyCapabilities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportResourceGroupEvent")]
            [Validation(Required=false)]
            public bool? SupportResourceGroupEvent { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2CB870A2-DF0F-5338-8223-F64737FF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

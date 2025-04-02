// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListResourceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5556E4C-479A-5BBB-B325-F07563E7E917</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource types.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<ListResourceTypesResponseBodyResourceTypes> ResourceTypes { get; set; }
        public class ListResourceTypesResponseBodyResourceTypes : TeaModel {
            /// <summary>
            /// <para>The code mapping of the resource type.</para>
            /// </summary>
            [NameInMap("CodeMapping")]
            [Validation(Required=false)]
            public ListResourceTypesResponseBodyResourceTypesCodeMapping CodeMapping { get; set; }
            public class ListResourceTypesResponseBodyResourceTypesCodeMapping : TeaModel {
                /// <summary>
                /// <para>The resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs.cluster</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <para>The tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs.cluster</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            /// <summary>
            /// <para>The supported filter conditions.</para>
            /// </summary>
            [NameInMap("FilterKeys")]
            [Validation(Required=false)]
            public List<string> FilterKeys { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Container Service for Kubernetes</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("RelatedResourceTypes")]
            [Validation(Required=false)]
            public List<string> RelatedResourceTypes { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ACK::Cluster</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The name of the resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cluster</para>
            /// </summary>
            [NameInMap("ResourceTypeName")]
            [Validation(Required=false)]
            public string ResourceTypeName { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupCapabilityResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a specific resource type or cloud service supports resource group events.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<ListResourceGroupCapabilityResponseBodyCapabilities> Capabilities { get; set; }
        public class ListResourceGroupCapabilityResponseBodyCapabilities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceCenterResourceType")]
            [Validation(Required=false)]
            public string ResourceCenterResourceType { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>You can obtain the resource type from the <b>Resource type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// <para>You can obtain the code from the <b>Service code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            /// <summary>
            /// <para>Indicates whether a specific resource type or cloud service supports resource group events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportResourceGroupEvent")]
            [Validation(Required=false)]
            public bool? SupportResourceGroupEvent { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CB870A2-DF0F-5338-8223-F64737FF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

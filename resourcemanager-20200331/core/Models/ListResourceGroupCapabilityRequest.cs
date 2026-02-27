// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupCapabilityRequest : TeaModel {
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
        /// <para>The ID of the Alibaba Cloud service.</para>
        /// <para>You can obtain the service code from the <b>Service code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>Specifies whether a specific resource type or cloud service supports resource group events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportResourceGroupEvent")]
        [Validation(Required=false)]
        public bool? SupportResourceGroupEvent { get; set; }

    }

}

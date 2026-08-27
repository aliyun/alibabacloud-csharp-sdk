// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The type of the resource. Call the <a href="https://help.aliyun.com/document_detail/133957.html">ListResourceTypes</a> operation to query supported resource types.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ECS::VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The version ID. Specify this parameter to query a specific version of the resource type. If you do not specify this parameter, the default version of the resource type is queried.</para>
        /// <remarks>
        /// <para>This parameter is supported only for modules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}

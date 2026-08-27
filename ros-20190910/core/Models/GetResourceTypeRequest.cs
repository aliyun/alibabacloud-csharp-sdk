// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The resource type.<br>For more information about the resource types supported by ROS, see <a href="https://help.aliyun.com/document_detail/127039.html">Resource type index</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ROS::WaitConditionHandle</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The version ID. To query a specific version of the resource type, specify this parameter. Otherwise, the resource type is queried.</para>
        /// <remarks>
        /// <para>Only modules support versions.</para>
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

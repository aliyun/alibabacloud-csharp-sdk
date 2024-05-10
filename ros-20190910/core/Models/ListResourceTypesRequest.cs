// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypesRequest : TeaModel {
        /// <summary>
        /// The entity type. Valid values:
        /// 
        /// *   All: all types of resources.
        /// *   Resource (default): regular resources. For more information, see [Resources](https://help.aliyun.com/document_detail/28863.html).
        /// *   DataSource: DataSource resources. For more information, see [DataSource resources](https://help.aliyun.com/document_detail/404753.html).
        /// *   Module: modules.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The provider of the resource type. Valid values:
        /// 
        /// *   ROS (default): The resource type is provided by Resource Orchestration Service (ROS).
        /// *   Self: The resource type is provided by you.
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// The resource type. The resource type can contain letters, digits, colons (:), and asterisks (\\*). You can use an asterisk (\\*) to perform a fuzzy match.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

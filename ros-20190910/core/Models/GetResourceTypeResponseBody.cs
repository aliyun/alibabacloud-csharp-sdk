// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// The type of the resource.
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The creation time. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The default version ID.
        /// 
        /// > This parameter is returned only if the resource type is queried.
        /// </summary>
        [NameInMap("DefaultVersionId")]
        [Validation(Required=false)]
        public string DefaultVersionId { get; set; }

        /// <summary>
        /// The description of the resource type.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The entity type. Valid values:
        /// 
        /// *   Resource: regular resource. For more information, see [Resources](~~28863~~).
        /// *   DataSource: DataSource resource. For more information, see [DataSource resources](~~404753~~).
        /// *   module: module.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Indicates whether the version is the default version. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// > This parameter is returned only if a specific version of the resource type is queried.
        /// </summary>
        [NameInMap("IsDefaultVersion")]
        [Validation(Required=false)]
        public bool? IsDefaultVersion { get; set; }

        /// <summary>
        /// The latest version ID.
        /// 
        /// > This parameter is returned only if the resource type is queried.
        /// </summary>
        [NameInMap("LatestVersionId")]
        [Validation(Required=false)]
        public string LatestVersionId { get; set; }

        /// <summary>
        /// Indicates whether the resource supports drift detection. Default value: false. Valid values:
        /// 
        /// *   true: Drift detection is supported.
        /// *   false: Drift detection is not supported.
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// The provider of the resource type. Valid values:
        /// 
        /// *   ROS: The resource type is provided by Resource Orchestration Service (ROS).
        /// *   Self: The resource type is provided by you.
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// The attributes of the resource.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The properties of the resource.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Indicates whether the resource supports scratch detection. Default value: false. Valid values:
        /// 
        /// *   true: Scratch detection is supported.
        /// *   false: Scratch detection is not supported.
        /// </summary>
        [NameInMap("SupportDriftDetection")]
        [Validation(Required=false)]
        public bool? SupportDriftDetection { get; set; }

        /// <summary>
        /// The entity type. Valid values:
        /// 
        /// *   Resource: resources other than DataSource resources. For more information, see [Resources](~~28863~~).
        /// *   DataSource: DataSource resources.
        /// </summary>
        [NameInMap("SupportScratchDetection")]
        [Validation(Required=false)]
        public bool? SupportScratchDetection { get; set; }

        /// <summary>
        /// The template content in the module.
        /// 
        /// > This parameter is returned only if a specific version of the resource type is queried.
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The total number of versions.
        /// 
        /// > This parameter is returned only if the resource type is queried.
        /// </summary>
        [NameInMap("TotalVersionCount")]
        [Validation(Required=false)]
        public int? TotalVersionCount { get; set; }

        /// <summary>
        /// The update time. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}

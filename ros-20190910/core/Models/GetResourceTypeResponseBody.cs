// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// The properties of the resource.
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DefaultVersionId")]
        [Validation(Required=false)]
        public string DefaultVersionId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("IsDefaultVersion")]
        [Validation(Required=false)]
        public bool? IsDefaultVersion { get; set; }

        [NameInMap("LatestVersionId")]
        [Validation(Required=false)]
        public string LatestVersionId { get; set; }

        /// <summary>
        /// Indicates whether the resource supports scratch detection. Default value: false. Valid values:
        /// 
        /// *   true: Scratch detection is supported.
        /// *   false: Scratch detection is not supported.
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the resource supports drift detection. Default value: false. Valid values:
        /// 
        /// *   true: Drift detection is supported.
        /// *   false: Drift detection is not supported.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The entity type. Valid values:
        /// 
        /// *   Resource: resources other than DataSource resources. For more information, see [Resources](~~28863~~).
        /// *   DataSource: DataSource resources.
        /// </summary>
        [NameInMap("SupportDriftDetection")]
        [Validation(Required=false)]
        public bool? SupportDriftDetection { get; set; }

        [NameInMap("SupportScratchDetection")]
        [Validation(Required=false)]
        public bool? SupportScratchDetection { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        [NameInMap("TotalVersionCount")]
        [Validation(Required=false)]
        public int? TotalVersionCount { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}

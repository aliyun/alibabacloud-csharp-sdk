// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// The attributes of the resource.
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The entity type. Valid values:
        /// 
        /// *   Resource: resources other than DataSource resources. For more information, see [Resources](~~28863~~).
        /// *   DataSource: DataSource resources.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The properties of the resource.
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Indicates whether the resource supports drift detection. Default value: false. Valid values:
        /// 
        /// *   true: Drift detection is supported.
        /// *   false: Drift detection is not supported.
        /// </summary>
        [NameInMap("SupportDriftDetection")]
        [Validation(Required=false)]
        public bool? SupportDriftDetection { get; set; }

        /// <summary>
        /// Indicates whether the resource supports scratch detection. Default value: false. Valid values:
        /// 
        /// *   true: Scratch detection is supported.
        /// *   false: Scratch detection is not supported.
        /// </summary>
        [NameInMap("SupportScratchDetection")]
        [Validation(Required=false)]
        public bool? SupportScratchDetection { get; set; }

    }

}

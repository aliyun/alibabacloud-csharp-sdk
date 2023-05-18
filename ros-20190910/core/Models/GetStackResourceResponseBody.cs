// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResourceResponseBody : TeaModel {
        /// <summary>
        /// The resource type.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The reason why the resource is in its current state.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the stack.
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// The time when the resource was updated.
        /// 
        /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// The list of the resource properties.
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("ModuleInfo")]
        [Validation(Required=false)]
        public GetStackResourceResponseBodyModuleInfo ModuleInfo { get; set; }
        public class GetStackResourceResponseBodyModuleInfo : TeaModel {
            [NameInMap("LogicalIdHierarchy")]
            [Validation(Required=false)]
            public string LogicalIdHierarchy { get; set; }

            [NameInMap("TypeHierarchy")]
            [Validation(Required=false)]
            public string TypeHierarchy { get; set; }

        }

        /// <summary>
        /// The metadata.
        /// </summary>
        [NameInMap("PhysicalResourceId")]
        [Validation(Required=false)]
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// The physical ID of the resource.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the resource in the last successful drift detection. Valid values:
        /// 
        /// *   DELETED: The actual configuration of the resource differs from its expected template configuration because the resource is deleted.
        /// *   MODIFIED: The actual configuration of the resource differs from its expected template configuration.
        /// *   NOT_CHECKED: ROS has not checked whether the actual configuration of the resource differs from its expected template configuration.
        /// *   IN_SYNC: The actual configuration of the resource matches its expected template configuration.
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ResourceAttributes { get; set; }

        /// <summary>
        /// The time when the last successful drift detection was performed on the stack.
        /// </summary>
        [NameInMap("ResourceDriftStatus")]
        [Validation(Required=false)]
        public string ResourceDriftStatus { get; set; }

        /// <summary>
        /// The logical ID of the resource defined in the template.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the resource was created.
        /// 
        /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// The name of the stack.
        /// 
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}

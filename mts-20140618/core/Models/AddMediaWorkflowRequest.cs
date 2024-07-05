// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddMediaWorkflowRequest : TeaModel {
        /// <summary>
        /// The name of the media workflow.
        /// 
        /// *   The value cannot be empty.
        /// *   The name cannot be the same as that of an existing media workflow within the current Alibaba Cloud account.
        /// *   The name can be up to 64 characters in length.
        /// *   The value must be encoded in the UTF-8 format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The topology of the media workflow. The value must be a JSON object that contains the activities and activity dependencies. For more information, see the **Sample topology** section of this topic.
        /// 
        /// >  The Object Storage Service (OSS) bucket must reside in the same region as your MPS service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topology")]
        [Validation(Required=false)]
        public string Topology { get; set; }

        /// <summary>
        /// The triggering mode of the media workflow. Valid values:
        /// 
        /// *   **OssAutoTrigger**: The media workflow is automatically triggered.
        /// *   **NotInAuto**: The media workflow is not automatically triggered.
        /// </summary>
        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}

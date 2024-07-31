// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateNodeRunModeRequest : TeaModel {
        /// <summary>
        /// The node ID. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the node ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// The environment in which the node runs. Valid values: DEV and PROD. The value DEV indicates the development environment, and the value PROD indicates the production environment.
        /// 
        /// *   PROD
        /// *   DEV
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// The operation that you want to perform on the node. Valid values:
        /// 
        /// *   0: indicates that you want to unfreeze the node.
        /// *   2: indicates that you want to freeze the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public int? SchedulerType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateApplicationConfigsRequest : TeaModel {
        /// <summary>
        /// The application configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<UpdateApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// The application name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The operation performed on configuration items. Valid values:
        /// 
        /// *   ADD
        /// *   UPDATE
        /// *   DELETE
        /// </summary>
        [NameInMap("ConfigAction")]
        [Validation(Required=false)]
        public string ConfigAction { get; set; }

        /// <summary>
        /// The operation scope. Valid values:
        /// 
        /// *   CLUSTER
        /// *   NODE_GROUP
        /// </summary>
        [NameInMap("ConfigScope")]
        [Validation(Required=false)]
        public string ConfigScope { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The node group ID.
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// The node ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Specifies whether to refresh the configurations.
        /// </summary>
        [NameInMap("RefreshConfig")]
        [Validation(Required=false)]
        public bool? RefreshConfig { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

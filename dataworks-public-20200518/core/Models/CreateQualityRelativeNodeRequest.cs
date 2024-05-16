// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityRelativeNodeRequest : TeaModel {
        /// <summary>
        /// The type of the compute engine instance or data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// The partition filter expression.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MatchExpression")]
        [Validation(Required=false)]
        public string MatchExpression { get; set; }

        /// <summary>
        /// The ID of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the compute engine instance or data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The name of the table.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the workspace to which the node to be associated with the partition filter expression belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetNodeProjectId")]
        [Validation(Required=false)]
        public long? TargetNodeProjectId { get; set; }

        /// <summary>
        /// The name of the workspace to which the node to be associated with the partition filter expression belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetNodeProjectName")]
        [Validation(Required=false)]
        public string TargetNodeProjectName { get; set; }

    }

}

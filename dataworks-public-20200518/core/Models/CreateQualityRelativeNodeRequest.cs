// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityRelativeNodeRequest : TeaModel {
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("MatchExpression")]
        [Validation(Required=false)]
        public string MatchExpression { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TargetNodeProjectId")]
        [Validation(Required=false)]
        public long? TargetNodeProjectId { get; set; }

        [NameInMap("TargetNodeProjectName")]
        [Validation(Required=false)]
        public string TargetNodeProjectName { get; set; }

    }

}

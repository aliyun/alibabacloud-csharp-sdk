// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateApplicationGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ApplicationGroup")]
        [Validation(Required=false)]
        public UpdateApplicationGroupResponseBodyApplicationGroup ApplicationGroup { get; set; }
        public class UpdateApplicationGroupResponseBodyApplicationGroup : TeaModel {
            [NameInMap("DeployRegionId")]
            [Validation(Required=false)]
            public string DeployRegionId { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }
            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }
            [NameInMap("ImportClusterId")]
            [Validation(Required=false)]
            public string ImportClusterId { get; set; }
        };

    }

}

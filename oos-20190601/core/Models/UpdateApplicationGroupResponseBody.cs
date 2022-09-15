// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateApplicationGroupResponseBody : TeaModel {
        [NameInMap("ApplicationGroup")]
        [Validation(Required=false)]
        public UpdateApplicationGroupResponseBodyApplicationGroup ApplicationGroup { get; set; }
        public class UpdateApplicationGroupResponseBodyApplicationGroup : TeaModel {
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            [NameInMap("DeployRegionId")]
            [Validation(Required=false)]
            public string DeployRegionId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImportTagKey")]
            [Validation(Required=false)]
            public string ImportTagKey { get; set; }

            [NameInMap("ImportTagValue")]
            [Validation(Required=false)]
            public string ImportTagValue { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

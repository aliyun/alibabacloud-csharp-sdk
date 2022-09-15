// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetApplicationGroupResponseBody : TeaModel {
        [NameInMap("ApplicationGroup")]
        [Validation(Required=false)]
        public GetApplicationGroupResponseBodyApplicationGroup ApplicationGroup { get; set; }
        public class GetApplicationGroupResponseBodyApplicationGroup : TeaModel {
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("CmsGroupId")]
            [Validation(Required=false)]
            public string CmsGroupId { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DeployOutputs")]
            [Validation(Required=false)]
            public string DeployOutputs { get; set; }

            [NameInMap("DeployParameters")]
            [Validation(Required=false)]
            public string DeployParameters { get; set; }

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

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

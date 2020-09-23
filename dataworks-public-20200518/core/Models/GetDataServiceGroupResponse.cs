// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceGroupResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Group")]
        [Validation(Required=true)]
        public GetDataServiceGroupResponseGroup Group { get; set; }
        public class GetDataServiceGroupResponseGroup : TeaModel {
            [NameInMap("TenantId")]
            [Validation(Required=true)]
            public long TenantId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=true)]
            public long ProjectId { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=true)]
            public string GroupId { get; set; }
            [NameInMap("ApiGatewayGroupId")]
            [Validation(Required=true)]
            public string ApiGatewayGroupId { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=true)]
            public string GroupName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=true)]
            public string CreatedTime { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=true)]
            public string ModifiedTime { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=true)]
            public string CreatorId { get; set; }
        };

    }

}

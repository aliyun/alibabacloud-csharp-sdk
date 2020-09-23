// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaDBInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetMetaDBInfoResponseData Data { get; set; }
        public class GetMetaDBInfoResponseData : TeaModel {
            [NameInMap("AppGuid")]
            [Validation(Required=true)]
            public string AppGuid { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=true)]
            public long TenantId { get; set; }
            [NameInMap("Endpoint")]
            [Validation(Required=true)]
            public string Endpoint { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=true)]
            public long ProjectId { get; set; }
            [NameInMap("EnvType")]
            [Validation(Required=true)]
            public int? EnvType { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=true)]
            public string ProjectName { get; set; }
            [NameInMap("ProjectNameCn")]
            [Validation(Required=true)]
            public string ProjectNameCn { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long CreateTime { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=true)]
            public long ModifyTime { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=true)]
            public string OwnerId { get; set; }
            [NameInMap("OwnerName")]
            [Validation(Required=true)]
            public string OwnerName { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=true)]
            public string Comment { get; set; }
            [NameInMap("Location")]
            [Validation(Required=true)]
            public string Location { get; set; }
            [NameInMap("ClusterBizId")]
            [Validation(Required=true)]
            public string ClusterBizId { get; set; }
        };

    }

}

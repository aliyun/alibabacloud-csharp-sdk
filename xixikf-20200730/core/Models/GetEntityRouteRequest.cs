// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetEntityRouteRequest : TeaModel {
        [NameInMap("EntityBizCode")]
        [Validation(Required=false)]
        public string EntityBizCode { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        [NameInMap("EntityRelationNumber")]
        [Validation(Required=false)]
        public string EntityRelationNumber { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public long? UniqueId { get; set; }

    }

}

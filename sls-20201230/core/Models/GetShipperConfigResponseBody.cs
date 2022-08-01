// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetShipperConfigResponseBody : TeaModel {
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        [NameInMap("shipperName")]
        [Validation(Required=false)]
        public string ShipperName { get; set; }

        [NameInMap("targetConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> TargetConfiguration { get; set; }

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}

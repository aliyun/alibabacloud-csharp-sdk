// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp_room20210515.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("Request")]
        [Validation(Required=false)]
        public CreateInstanceRequestRequest Request { get; set; }
        public class CreateInstanceRequestRequest : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }
            [NameInMap("PluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }
        };

    }

}

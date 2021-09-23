// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HostGroup")]
        [Validation(Required=false)]
        public GetHostGroupResponseBodyHostGroup HostGroup { get; set; }
        public class GetHostGroupResponseBodyHostGroup : TeaModel {
            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("HostGroupName")]
            [Validation(Required=false)]
            public string HostGroupName { get; set; }
        };

    }

}

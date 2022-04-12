// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindSlbResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindSlbResponseBodyData Data { get; set; }
        public class BindSlbResponseBodyData : TeaModel {
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }
            [NameInMap("ExtVServerGroupId")]
            [Validation(Required=false)]
            public string ExtVServerGroupId { get; set; }
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public int? SlbPort { get; set; }
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

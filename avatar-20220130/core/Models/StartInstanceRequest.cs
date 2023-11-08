// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class StartInstanceRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public StartInstanceRequestApp App { get; set; }
        public class StartInstanceRequestApp : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

        }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public StartInstanceRequestChannel Channel { get; set; }
        public class StartInstanceRequestChannel : TeaModel {
            [NameInMap("ReqConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> ReqConfig { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("CommandRequest")]
        [Validation(Required=false)]
        public StartInstanceRequestCommandRequest CommandRequest { get; set; }
        public class StartInstanceRequestCommandRequest : TeaModel {
            [NameInMap("AlphaSwitch")]
            [Validation(Required=false)]
            public bool? AlphaSwitch { get; set; }

        }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public StartInstanceRequestUser User { get; set; }
        public class StartInstanceRequestUser : TeaModel {
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}

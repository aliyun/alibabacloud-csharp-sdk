// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class UpdateAccountPasswordResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("Account")]
        [Validation(Required=true)]
        public UpdateAccountPasswordResponseAccount Account { get; set; }
        public class UpdateAccountPasswordResponseAccount : TeaModel {
            [NameInMap("UserName")]
            [Validation(Required=true)]
            public string UserName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=true)]
            public string Password { get; set; }
        };

    }

}

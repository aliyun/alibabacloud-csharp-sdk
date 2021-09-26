// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class RegisterNoticeMailRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Mail")]
        [Validation(Required=false)]
        public string Mail { get; set; }

        [NameInMap("Vcode")]
        [Validation(Required=false)]
        public string Vcode { get; set; }

    }

}

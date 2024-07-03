// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateNacUserCertStatusRequest : TeaModel {
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<UpdateNacUserCertStatusRequestIdList> IdList { get; set; }
        public class UpdateNacUserCertStatusRequestIdList : TeaModel {
            [NameInMap("DevTag")]
            [Validation(Required=false)]
            public string DevTag { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

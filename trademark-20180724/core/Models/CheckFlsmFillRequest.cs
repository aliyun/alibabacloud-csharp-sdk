// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CheckFlsmFillRequest : TeaModel {
        [NameInMap("ApplicantType")]
        [Validation(Required=false)]
        public string ApplicantType { get; set; }

        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        [NameInMap("PersonalType")]
        [Validation(Required=false)]
        public string PersonalType { get; set; }

        [NameInMap("WtrName")]
        [Validation(Required=false)]
        public string WtrName { get; set; }

    }

}

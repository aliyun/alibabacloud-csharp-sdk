// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateAuthKeyRequest : TeaModel {
        [NameInMap("AuthYears")]
        [Validation(Required=false)]
        public int? AuthYears { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Test")]
        [Validation(Required=false)]
        public bool? Test { get; set; }

        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}

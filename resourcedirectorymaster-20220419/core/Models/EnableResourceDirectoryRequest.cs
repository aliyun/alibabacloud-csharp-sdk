// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class EnableResourceDirectoryRequest : TeaModel {
        [NameInMap("EnableMode")]
        [Validation(Required=false)]
        public string EnableMode { get; set; }

        [NameInMap("MAName")]
        [Validation(Required=false)]
        public string MAName { get; set; }

        [NameInMap("MASecureMobilePhone")]
        [Validation(Required=false)]
        public string MASecureMobilePhone { get; set; }

        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}

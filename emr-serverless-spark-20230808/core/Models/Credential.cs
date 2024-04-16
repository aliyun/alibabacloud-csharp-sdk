// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Credential : TeaModel {
        [NameInMap("accessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        [NameInMap("dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        [NameInMap("expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("securityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnConfigOfVersionRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        [NameInMap("FunctionId")]
        [Validation(Required=false)]
        public long? FunctionId { get; set; }

        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("FunctionArgs")]
        [Validation(Required=false)]
        public string FunctionArgs { get; set; }

    }

}

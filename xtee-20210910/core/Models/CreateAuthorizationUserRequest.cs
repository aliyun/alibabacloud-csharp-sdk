// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateAuthorizationUserRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("bindId")]
        [Validation(Required=false)]
        public long? BindId { get; set; }

        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        [NameInMap("eventTemplateId")]
        [Validation(Required=false)]
        public long? EventTemplateId { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

    }

}

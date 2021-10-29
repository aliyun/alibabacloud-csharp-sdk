// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class ModifyReadOnlyAccountPasswordRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("NewPasswd")]
        [Validation(Required=false)]
        public string NewPasswd { get; set; }

        [NameInMap("OriginPassword")]
        [Validation(Required=false)]
        public string OriginPassword { get; set; }

    }

}

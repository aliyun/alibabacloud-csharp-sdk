// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateDbRequest : TeaModel {
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        [NameInMap("DbDescription")]
        [Validation(Required=false)]
        public string DbDescription { get; set; }

        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DeleteBodyPersonRequest : TeaModel {
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public long? PersonId { get; set; }

    }

}

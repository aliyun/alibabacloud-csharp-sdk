// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteMultiRateConfigRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public string DeleteAll { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public string Templates { get; set; }

    }

}

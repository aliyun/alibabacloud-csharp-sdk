// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class AddBusinessGroupOneRequest : TeaModel {
        [NameInMap("BusinessGroupDesc")]
        [Validation(Required=false)]
        public string BusinessGroupDesc { get; set; }

        [NameInMap("BusinessGroupName")]
        [Validation(Required=false)]
        public string BusinessGroupName { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}

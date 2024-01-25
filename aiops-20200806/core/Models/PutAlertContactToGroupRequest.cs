// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class PutAlertContactToGroupRequest : TeaModel {
        [NameInMap("ContactIdListJson")]
        [Validation(Required=false)]
        public string ContactIdListJson { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupIdListJson")]
        [Validation(Required=false)]
        public string GroupIdListJson { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}

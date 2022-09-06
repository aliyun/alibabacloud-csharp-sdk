// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveContactWhiteListRequest : TeaModel {
        [NameInMap("ContactWhiteListList")]
        [Validation(Required=false)]
        public List<string> ContactWhiteListList { get; set; }

        [NameInMap("ContactWhiteListsJson")]
        [Validation(Required=false)]
        public string ContactWhiteListsJson { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

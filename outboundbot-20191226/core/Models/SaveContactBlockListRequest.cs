// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveContactBlockListRequest : TeaModel {
        [NameInMap("ContactBlockListList")]
        [Validation(Required=false)]
        public List<string> ContactBlockListList { get; set; }

        [NameInMap("ContactBlockListsJson")]
        [Validation(Required=false)]
        public string ContactBlockListsJson { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMonitorGroupRequest : TeaModel {
        [NameInMap("BindUrls")]
        [Validation(Required=false)]
        public string BindUrls { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class DeleteAlertContactGroupRequest : TeaModel {
        [NameInMap("ContactGroupId")]
        [Validation(Required=false)]
        public long? ContactGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

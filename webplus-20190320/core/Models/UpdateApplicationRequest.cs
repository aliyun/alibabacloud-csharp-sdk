// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class UpdateApplicationRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteDSTBizLogConfigRequest : TeaModel {
        [NameInMap("BizLogConfigId")]
        [Validation(Required=false)]
        public long? BizLogConfigId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

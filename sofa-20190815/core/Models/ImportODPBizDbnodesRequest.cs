// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ImportODPBizDbnodesRequest : TeaModel {
        [NameInMap("DbInstanceIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> DbInstanceIdsRepeatList { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

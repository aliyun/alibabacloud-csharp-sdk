// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPDbnodesRequest : TeaModel {
        [NameInMap("FilterAvailable")]
        [Validation(Required=false)]
        public bool? FilterAvailable { get; set; }

        [NameInMap("FilterInstanceType")]
        [Validation(Required=false)]
        public string FilterInstanceType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

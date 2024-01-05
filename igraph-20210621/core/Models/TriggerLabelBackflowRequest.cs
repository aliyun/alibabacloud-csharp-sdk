// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Igraph20210621.Models
{
    public class TriggerLabelBackflowRequest : TeaModel {
        [NameInMap("odpsPartition")]
        [Validation(Required=false)]
        public string OdpsPartition { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}

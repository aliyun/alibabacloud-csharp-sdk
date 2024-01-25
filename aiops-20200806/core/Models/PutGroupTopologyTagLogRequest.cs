// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class PutGroupTopologyTagLogRequest : TeaModel {
        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("TopologyTag")]
        [Validation(Required=false)]
        public string TopologyTag { get; set; }

        [NameInMap("TopologyTagShow")]
        [Validation(Required=false)]
        public string TopologyTagShow { get; set; }

    }

}

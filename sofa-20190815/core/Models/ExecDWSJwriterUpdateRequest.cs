// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecDWSJwriterUpdateRequest : TeaModel {
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JdbcwriterTimestamp")]
        [Validation(Required=false)]
        public long? JdbcwriterTimestamp { get; set; }

        [NameInMap("WriterName")]
        [Validation(Required=false)]
        public string WriterName { get; set; }

    }

}

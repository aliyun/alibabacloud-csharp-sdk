// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsRequest : TeaModel {
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        [NameInMap("pack_id")]
        [Validation(Required=false)]
        public string PackId { get; set; }

        [NameInMap("pack_meta")]
        [Validation(Required=false)]
        public string PackMeta { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

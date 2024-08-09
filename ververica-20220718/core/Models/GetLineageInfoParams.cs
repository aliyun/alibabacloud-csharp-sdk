// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetLineageInfoParams : TeaModel {
        [NameInMap("depth")]
        [Validation(Required=false)]
        public long? Depth { get; set; }

        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("idType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

        [NameInMap("isColumnLevel")]
        [Validation(Required=false)]
        public bool? IsColumnLevel { get; set; }

        [NameInMap("isTemporary")]
        [Validation(Required=false)]
        public bool? IsTemporary { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

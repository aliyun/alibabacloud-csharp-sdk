// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDefaultCollectorConfigurationsRequest : TeaModel {
        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        [NameInMap("resVersion")]
        [Validation(Required=false)]
        public string ResVersion { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}

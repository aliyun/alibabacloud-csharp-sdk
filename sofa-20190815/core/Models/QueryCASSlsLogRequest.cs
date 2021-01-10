// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCASSlsLogRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        [NameInMap("Line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

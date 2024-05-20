// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class PostMSDataProcessingCountRequest : TeaModel {
        [NameInMap("DataIds")]
        [Validation(Required=false)]
        public List<string> DataIds { get; set; }

        [NameInMap("DataImportId")]
        [Validation(Required=false)]
        public long? DataImportId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("X-DashScope-OpenAPISource")]
        [Validation(Required=false)]
        public string XDashScopeOpenAPISource { get; set; }

    }

}

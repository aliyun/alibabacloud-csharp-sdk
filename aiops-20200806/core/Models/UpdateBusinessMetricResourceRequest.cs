// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateBusinessMetricResourceRequest : TeaModel {
        [NameInMap("BusinessMetricId")]
        [Validation(Required=false)]
        public long? BusinessMetricId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public string ResourceList { get; set; }

    }

}

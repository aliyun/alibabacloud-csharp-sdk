// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class PostMSServiceDataImportShrinkRequest : TeaModel {
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeSchemaDetailRequest : TeaModel {
        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public long? SchemaId { get; set; }

    }

}

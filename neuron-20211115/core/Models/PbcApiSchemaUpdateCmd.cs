// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcApiSchemaUpdateCmd : TeaModel {
        [NameInMap("apiSchema")]
        [Validation(Required=false)]
        public string ApiSchema { get; set; }

        [NameInMap("pbcVersionId")]
        [Validation(Required=false)]
        public long? PbcVersionId { get; set; }

    }

}

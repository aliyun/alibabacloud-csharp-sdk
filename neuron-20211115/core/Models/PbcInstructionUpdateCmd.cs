// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcInstructionUpdateCmd : TeaModel {
        [NameInMap("document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        [NameInMap("pbcVersionId")]
        [Validation(Required=false)]
        public long? PbcVersionId { get; set; }

    }

}

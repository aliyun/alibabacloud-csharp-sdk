// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcSubscribe : TeaModel {
        [NameInMap("developerId")]
        [Validation(Required=false)]
        public string DeveloperId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("pbcName")]
        [Validation(Required=false)]
        public string PbcName { get; set; }

        [NameInMap("purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        [NameInMap("subPbcName")]
        [Validation(Required=false)]
        public string SubPbcName { get; set; }

    }

}

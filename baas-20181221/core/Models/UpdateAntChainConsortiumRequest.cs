// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class UpdateAntChainConsortiumRequest : TeaModel {
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("ConsortiumName")]
        [Validation(Required=false)]
        public string ConsortiumName { get; set; }

        [NameInMap("ConsortiumDescription")]
        [Validation(Required=false)]
        public string ConsortiumDescription { get; set; }

    }

}

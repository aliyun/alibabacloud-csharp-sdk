// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class CreateAntChainConsortiumRequest : TeaModel {
        [NameInMap("ConsortiumDescription")]
        [Validation(Required=false)]
        public string ConsortiumDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsortiumName")]
        [Validation(Required=false)]
        public string ConsortiumName { get; set; }

    }

}

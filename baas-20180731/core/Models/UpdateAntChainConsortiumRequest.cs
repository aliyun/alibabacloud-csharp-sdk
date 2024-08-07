// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpdateAntChainConsortiumRequest : TeaModel {
        [NameInMap("ConsortiumDescription")]
        [Validation(Required=false)]
        public string ConsortiumDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsortiumName")]
        [Validation(Required=false)]
        public string ConsortiumName { get; set; }

    }

}

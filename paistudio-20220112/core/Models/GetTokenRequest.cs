// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTokenRequest : TeaModel {
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrainingJobId")]
        [Validation(Required=false)]
        public string TrainingJobId { get; set; }

    }

}

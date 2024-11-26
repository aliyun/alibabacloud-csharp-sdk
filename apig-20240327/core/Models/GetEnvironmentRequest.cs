// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetEnvironmentRequest : TeaModel {
        [NameInMap("withStatistics")]
        [Validation(Required=false)]
        public bool? WithStatistics { get; set; }

        /// <summary>
        /// <para>Option for vpc info.</para>
        /// </summary>
        [NameInMap("withVpcInfo")]
        [Validation(Required=false)]
        public bool? WithVpcInfo { get; set; }

    }

}

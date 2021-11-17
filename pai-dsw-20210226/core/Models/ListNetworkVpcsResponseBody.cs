// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListNetworkVpcsResponseBody : TeaModel {
        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// vpc列表
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public List<Vpc> Vpcs { get; set; }

    }

}

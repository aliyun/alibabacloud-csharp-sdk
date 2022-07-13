// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wfts20220212.Models
{
    public class GetLjxAccountInfoResponseBody : TeaModel {
        [NameInMap("Apple")]
        [Validation(Required=false)]
        public string Apple { get; set; }

        /// <summary>
        /// 资源一级ID
        /// </summary>
        [NameInMap("LjxAccountInfoId")]
        [Validation(Required=false)]
        public string LjxAccountInfoId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class CreateCouponTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContextMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextMap { get; set; }

        /// <summary>
        /// result data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

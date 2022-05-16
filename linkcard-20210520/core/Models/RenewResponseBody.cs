// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class RenewResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RenewResponseBodyData Data { get; set; }
        public class RenewResponseBodyData : TeaModel {
            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }
            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

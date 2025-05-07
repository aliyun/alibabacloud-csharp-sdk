// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class BusinessResultServiceRequest : TeaModel {
        [NameInMap("ActionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        [NameInMap("BussinessCode")]
        [Validation(Required=false)]
        public string BussinessCode { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

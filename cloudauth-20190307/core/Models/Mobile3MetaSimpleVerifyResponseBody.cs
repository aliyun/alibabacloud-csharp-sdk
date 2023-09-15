// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaSimpleVerifyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Mobile3MetaSimpleVerifyResponseBodyResultObject ResultObject { get; set; }
        public class Mobile3MetaSimpleVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

        }

    }

}

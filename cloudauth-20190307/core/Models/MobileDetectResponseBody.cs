// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileDetectResponseBody : TeaModel {
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
        public MobileDetectResponseBodyResultObject ResultObject { get; set; }
        public class MobileDetectResponseBodyResultObject : TeaModel {
            [NameInMap("ChargeCount")]
            [Validation(Required=false)]
            public string ChargeCount { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<MobileDetectResponseBodyResultObjectItems> Items { get; set; }
            public class MobileDetectResponseBodyResultObjectItems : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("BizCode")]
                [Validation(Required=false)]
                public string BizCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("SubCode")]
                [Validation(Required=false)]
                public string SubCode { get; set; }

            }

        }

    }

}

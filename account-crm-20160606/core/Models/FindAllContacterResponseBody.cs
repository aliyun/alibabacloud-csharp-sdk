// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class FindAllContacterResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindAllContacterResponseBodyData Data { get; set; }
        public class FindAllContacterResponseBodyData : TeaModel {
            [NameInMap("ContacterInfo")]
            [Validation(Required=false)]
            public List<FindAllContacterResponseBodyDataContacterInfo> ContacterInfo { get; set; }
            public class FindAllContacterResponseBodyDataContacterInfo : TeaModel {
                [NameInMap("ContacterAddress")]
                [Validation(Required=false)]
                public string ContacterAddress { get; set; }

                [NameInMap("ContacterDingding")]
                [Validation(Required=false)]
                public string ContacterDingding { get; set; }

                [NameInMap("ContacterEmail")]
                [Validation(Required=false)]
                public string ContacterEmail { get; set; }

                [NameInMap("ContacterId")]
                [Validation(Required=false)]
                public long? ContacterId { get; set; }

                [NameInMap("ContacterMobile")]
                [Validation(Required=false)]
                public string ContacterMobile { get; set; }

                [NameInMap("ContacterName")]
                [Validation(Required=false)]
                public string ContacterName { get; set; }

                [NameInMap("ContacterPosition")]
                [Validation(Required=false)]
                public string ContacterPosition { get; set; }

                [NameInMap("ContacterStaffNo")]
                [Validation(Required=false)]
                public string ContacterStaffNo { get; set; }

                [NameInMap("ContacterType")]
                [Validation(Required=false)]
                public string ContacterType { get; set; }

                [NameInMap("ContacterWangwang")]
                [Validation(Required=false)]
                public string ContacterWangwang { get; set; }

                [NameInMap("EmailConfirmed")]
                [Validation(Required=false)]
                public bool? EmailConfirmed { get; set; }

                [NameInMap("MobileConfirmed")]
                [Validation(Required=false)]
                public bool? MobileConfirmed { get; set; }

            }

        }

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

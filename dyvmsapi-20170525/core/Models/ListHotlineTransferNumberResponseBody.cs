// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListHotlineTransferNumberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotlineTransferNumberResponseBodyData Data { get; set; }
        public class ListHotlineTransferNumberResponseBodyData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<ListHotlineTransferNumberResponseBodyDataValues> Values { get; set; }
            public class ListHotlineTransferNumberResponseBodyDataValues : TeaModel {
                public string PhoneNumber { get; set; }
                public string NumberOwnerName { get; set; }
                public string QualificationId { get; set; }
                public string HotlineNumber { get; set; }
                public string IdentityCard { get; set; }
                public string ResUniqueCode { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListHotlineTransferRegisterFileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHotlineTransferRegisterFileResponseBodyData Data { get; set; }
        public class ListHotlineTransferRegisterFileResponseBodyData : TeaModel {
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
            public List<ListHotlineTransferRegisterFileResponseBodyDataValues> Values { get; set; }
            public class ListHotlineTransferRegisterFileResponseBodyDataValues : TeaModel {
                public string Agree { get; set; }
                public string CorpName { get; set; }
                public string HotlineNumber { get; set; }
                public string MngOpIdentityCard { get; set; }
                public string MngOpMail { get; set; }
                public string MngOpMobile { get; set; }
                public string MngOpName { get; set; }
                public string QualificationId { get; set; }
                public long? ResUniqueCode { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

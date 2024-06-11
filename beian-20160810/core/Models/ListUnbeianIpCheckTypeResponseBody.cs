// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Beian20160810.Models
{
    public class ListUnbeianIpCheckTypeResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HuntressIpCheckTypeResultDO")]
        [Validation(Required=false)]
        public ListUnbeianIpCheckTypeResponseBodyHuntressIpCheckTypeResultDO HuntressIpCheckTypeResultDO { get; set; }
        public class ListUnbeianIpCheckTypeResponseBodyHuntressIpCheckTypeResultDO : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListUnbeianIpCheckTypeResponseBodyHuntressIpCheckTypeResultDOList> List { get; set; }
            public class ListUnbeianIpCheckTypeResponseBodyHuntressIpCheckTypeResultDOList : TeaModel {
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public int? CheckType { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

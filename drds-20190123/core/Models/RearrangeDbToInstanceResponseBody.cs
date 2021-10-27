// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class RearrangeDbToInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RearrangeDbToInstanceResponseBodyData Data { get; set; }
        public class RearrangeDbToInstanceResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<RearrangeDbToInstanceResponseBodyDataData> Data { get; set; }
            public class RearrangeDbToInstanceResponseBodyDataData : TeaModel {
                public string DstInstance { get; set; }
                public string SrcDbName { get; set; }
                public string SrcInstance { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetChangeLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetChangeLogResponseBodyData> Data { get; set; }
        public class GetChangeLogResponseBodyData : TeaModel {
            [NameInMap("OldValue")]
            [Validation(Required=false)]
            public string OldValue { get; set; }

            [NameInMap("PropertyType")]
            [Validation(Required=false)]
            public string PropertyType { get; set; }

            [NameInMap("PropertyKey")]
            [Validation(Required=false)]
            public string PropertyKey { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public int? TargetId { get; set; }

            [NameInMap("Other")]
            [Validation(Required=false)]
            public string Other { get; set; }

            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

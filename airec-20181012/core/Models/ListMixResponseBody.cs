// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListMixResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListMixResponseBodyResult> Result { get; set; }
        public class ListMixResponseBodyResult : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public ListMixResponseBodyResultParameter Parameter { get; set; }
            public class ListMixResponseBodyResultParameter : TeaModel {
                [NameInMap("Settings")]
                [Validation(Required=false)]
                public List<ListMixResponseBodyResultParameterSettings> Settings { get; set; }
                public class ListMixResponseBodyResultParameterSettings : TeaModel {
                    public int? Value { get; set; }
                    public string Name { get; set; }
                }
            };

        }

    }

}

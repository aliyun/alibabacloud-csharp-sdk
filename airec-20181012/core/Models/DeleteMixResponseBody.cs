// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DeleteMixResponseBody : TeaModel {
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
        public DeleteMixResponseBodyResult Result { get; set; }
        public class DeleteMixResponseBodyResult : TeaModel {
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
            public DeleteMixResponseBodyResultParameter Parameter { get; set; }
            public class DeleteMixResponseBodyResultParameter : TeaModel {
                [NameInMap("Settings")]
                [Validation(Required=false)]
                public List<DeleteMixResponseBodyResultParameterSettings> Settings { get; set; }
                public class DeleteMixResponseBodyResultParameterSettings : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class CreateNormalAccountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateNormalAccountResponseBodyData Data { get; set; }
        public class CreateNormalAccountResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<CreateNormalAccountResponseBodyDataResult> Result { get; set; }
            public class CreateNormalAccountResponseBodyDataResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("EachData")]
                [Validation(Required=false)]
                public CreateNormalAccountResponseBodyDataResultEachData EachData { get; set; }
                public class CreateNormalAccountResponseBodyDataResultEachData : TeaModel {
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("RegUrl")]
                    [Validation(Required=false)]
                    public string RegUrl { get; set; }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

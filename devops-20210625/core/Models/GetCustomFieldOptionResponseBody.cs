// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCustomFieldOptionResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("fileds")]
        [Validation(Required=false)]
        public List<GetCustomFieldOptionResponseBodyFileds> Fileds { get; set; }
        public class GetCustomFieldOptionResponseBodyFileds : TeaModel {
            [NameInMap("displayValue")]
            [Validation(Required=false)]
            public string DisplayValue { get; set; }

            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("valueEn")]
            [Validation(Required=false)]
            public string ValueEn { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

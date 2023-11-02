// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeLogFieldsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeLogFieldsResponseBodyData> Data { get; set; }
        public class DescribeLogFieldsResponseBodyData : TeaModel {
            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("FieldDesc")]
            [Validation(Required=false)]
            public string FieldDesc { get; set; }

            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("FieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliyunAuth20181222.Models
{
    public class AuthenticateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AuthenticateResponseBodyData Data { get; set; }
        public class AuthenticateResponseBodyData : TeaModel {
            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OperateCode")]
            [Validation(Required=false)]
            public string OperateCode { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("RecordVid")]
            [Validation(Required=false)]
            public string RecordVid { get; set; }

            [NameInMap("UserInputList")]
            [Validation(Required=false)]
            public AuthenticateResponseBodyDataUserInputList UserInputList { get; set; }
            public class AuthenticateResponseBodyDataUserInputList : TeaModel {
                [NameInMap("QueryAuthRSDTO")]
                [Validation(Required=false)]
                public List<AuthenticateResponseBodyDataUserInputListQueryAuthRSDTO> QueryAuthRSDTO { get; set; }
                public class AuthenticateResponseBodyDataUserInputListQueryAuthRSDTO : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("ExpandContent")]
                    [Validation(Required=false)]
                    public string ExpandContent { get; set; }

                    [NameInMap("FieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("FieldVid")]
                    [Validation(Required=false)]
                    public string FieldVid { get; set; }

                }

            }

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

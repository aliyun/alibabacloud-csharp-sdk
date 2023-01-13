// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetStudioAppTokenOpenResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetStudioAppTokenOpenResponseData Data { get; set; }
        public class GetStudioAppTokenOpenResponseData : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=true)]
            public string BizId { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=true)]
            public string BizType { get; set; }

            [NameInMap("IsEnable")]
            [Validation(Required=true)]
            public string IsEnable { get; set; }

            [NameInMap("Token")]
            [Validation(Required=true)]
            public string Token { get; set; }

            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }

        }

    }

}

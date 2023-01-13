// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateStudioAppDomainOpenResponse : TeaModel {
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
        public CreateStudioAppDomainOpenResponseData Data { get; set; }
        public class CreateStudioAppDomainOpenResponseData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=true)]
            public string AppId { get; set; }

            [NameInMap("Host")]
            [Validation(Required=true)]
            public string Host { get; set; }

            [NameInMap("Id")]
            [Validation(Required=true)]
            public int? Id { get; set; }

            [NameInMap("IsBeian")]
            [Validation(Required=true)]
            public string IsBeian { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=true)]
            public string ProjectId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=true)]
            public string Protocol { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=true)]
            public string TenantId { get; set; }

        }

    }

}

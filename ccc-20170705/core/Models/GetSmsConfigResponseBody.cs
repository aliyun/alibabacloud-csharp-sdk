// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetSmsConfigResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("SmsConfigs")]
        [Validation(Required=false)]
        public GetSmsConfigResponseBodySmsConfigs SmsConfigs { get; set; }
        public class GetSmsConfigResponseBodySmsConfigs : TeaModel {
            [NameInMap("SmsConfig")]
            [Validation(Required=false)]
            public List<GetSmsConfigResponseBodySmsConfigsSmsConfig> SmsConfig { get; set; }
            public class GetSmsConfigResponseBodySmsConfigsSmsConfig : TeaModel {
                public string Instance { get; set; }
                public string Description { get; set; }
                public string TemplateCode { get; set; }
                public string GmtCreate { get; set; }
                public int? Scenario { get; set; }
                public string GmtModified { get; set; }
                public string Name { get; set; }
                public string Extra { get; set; }
                public string SignName { get; set; }
                public long? Id { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

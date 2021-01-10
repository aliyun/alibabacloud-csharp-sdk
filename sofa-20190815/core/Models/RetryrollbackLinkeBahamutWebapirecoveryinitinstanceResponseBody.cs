// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RetryrollbackLinkeBahamutWebapirecoveryinitinstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public RetryrollbackLinkeBahamutWebapirecoveryinitinstanceResponseBodyResult Result { get; set; }
        public class RetryrollbackLinkeBahamutWebapirecoveryinitinstanceResponseBodyResult : TeaModel {
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("InVisible")]
            [Validation(Required=false)]
            public bool? InVisible { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }
            [NameInMap("Pipeline")]
            [Validation(Required=false)]
            public string Pipeline { get; set; }
            [NameInMap("PipelineInstanceId")]
            [Validation(Required=false)]
            public long? PipelineInstanceId { get; set; }
            [NameInMap("PipelineTemplateId")]
            [Validation(Required=false)]
            public long? PipelineTemplateId { get; set; }
            [NameInMap("PipelineTrigger")]
            [Validation(Required=false)]
            public string PipelineTrigger { get; set; }
        };

    }

}

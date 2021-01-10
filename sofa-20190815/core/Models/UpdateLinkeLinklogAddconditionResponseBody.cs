// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinklogAddconditionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseContentRange")]
        [Validation(Required=false)]
        public string ResponseContentRange { get; set; }

        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateLinkeLinklogAddconditionResponseBodyResult Result { get; set; }
        public class UpdateLinkeLinklogAddconditionResponseBodyResult : TeaModel {
            [NameInMap("Compiled")]
            [Validation(Required=false)]
            public string Compiled { get; set; }
            [NameInMap("ConditionId")]
            [Validation(Required=false)]
            public long? ConditionId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("IndicationId")]
            [Validation(Required=false)]
            public long? IndicationId { get; set; }
            [NameInMap("LogSample")]
            [Validation(Required=false)]
            public string LogSample { get; set; }
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }
        };

    }

}

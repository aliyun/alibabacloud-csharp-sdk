// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateRmsAlertrulePauseResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public UpdateRmsAlertrulePauseResponseBodyResponse Response { get; set; }
        public class UpdateRmsAlertrulePauseResponseBodyResponse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public UpdateRmsAlertrulePauseResponseBodyResponseEntity Entity { get; set; }
            public class UpdateRmsAlertrulePauseResponseBodyResponseEntity : TeaModel {
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("ErrResolution")]
                [Validation(Required=false)]
                public string ErrResolution { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Module")]
                [Validation(Required=false)]
                public bool? Module { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }
        };

    }

}

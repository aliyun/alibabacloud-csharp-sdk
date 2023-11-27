// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateMsgRecallIntervalRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public UpdateMsgRecallIntervalRequestRequestParams RequestParams { get; set; }
        public class UpdateMsgRecallIntervalRequestRequestParams : TeaModel {
            [NameInMap("ClientMsgRecallIntervalMinute")]
            [Validation(Required=false)]
            public long? ClientMsgRecallIntervalMinute { get; set; }

        }

    }

}

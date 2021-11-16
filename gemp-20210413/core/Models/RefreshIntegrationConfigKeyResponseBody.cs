// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class RefreshIntegrationConfigKeyResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public RefreshIntegrationConfigKeyResponseBodyData Data { get; set; }
        public class RefreshIntegrationConfigKeyResponseBodyData : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

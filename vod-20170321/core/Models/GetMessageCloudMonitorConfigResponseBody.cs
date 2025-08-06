// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMessageCloudMonitorConfigResponseBody : TeaModel {
        [NameInMap("MessageCloudMonitorConfig")]
        [Validation(Required=false)]
        public GetMessageCloudMonitorConfigResponseBodyMessageCloudMonitorConfig MessageCloudMonitorConfig { get; set; }
        public class GetMessageCloudMonitorConfigResponseBodyMessageCloudMonitorConfig : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public string EventTypeList { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

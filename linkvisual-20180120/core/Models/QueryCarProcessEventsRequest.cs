// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryCarProcessEventsRequest : TeaModel {
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        [NameInMap("AreaIndex")]
        [Validation(Required=false)]
        public int? AreaIndex { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PlateNo")]
        [Validation(Required=false)]
        public string PlateNo { get; set; }

        [NameInMap("SubDeviceName")]
        [Validation(Required=false)]
        public string SubDeviceName { get; set; }

        [NameInMap("SubIotId")]
        [Validation(Required=false)]
        public string SubIotId { get; set; }

        [NameInMap("SubProductKey")]
        [Validation(Required=false)]
        public string SubProductKey { get; set; }

    }

}

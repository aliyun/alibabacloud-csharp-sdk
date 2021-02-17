// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttGroupIdListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMqttGroupIdListResponseBodyData Data { get; set; }
        public class OnsMqttGroupIdListResponseBodyData : TeaModel {
            [NameInMap("MqttGroupIdDo")]
            [Validation(Required=false)]
            public List<OnsMqttGroupIdListResponseBodyDataMqttGroupIdDo> MqttGroupIdDo { get; set; }
            public class OnsMqttGroupIdListResponseBodyDataMqttGroupIdDo : TeaModel {
                public long? UpdateTime { get; set; }
                public bool? IndependentNaming { get; set; }
                public string GroupId { get; set; }
                public long? CreateTime { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}

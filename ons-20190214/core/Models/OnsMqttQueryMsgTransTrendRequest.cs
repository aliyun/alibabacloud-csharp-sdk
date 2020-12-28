// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttQueryMsgTransTrendRequest : TeaModel {
        [NameInMap("TpsType")]
        [Validation(Required=false)]
        public string TpsType { get; set; }

        [NameInMap("TransType")]
        [Validation(Required=false)]
        public string TransType { get; set; }

        [NameInMap("ParentTopic")]
        [Validation(Required=false)]
        public string ParentTopic { get; set; }

        [NameInMap("SubTopic")]
        [Validation(Required=false)]
        public string SubTopic { get; set; }

        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

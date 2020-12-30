// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentDevicesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("AgentDeviceList")]
        [Validation(Required=false)]
        public ListAgentDevicesResponseBodyAgentDeviceList AgentDeviceList { get; set; }
        public class ListAgentDevicesResponseBodyAgentDeviceList : TeaModel {
            [NameInMap("AgentDevice")]
            [Validation(Required=false)]
            public List<ListAgentDevicesResponseBodyAgentDeviceListAgentDevice> AgentDevice { get; set; }
            public class ListAgentDevicesResponseBodyAgentDeviceListAgentDevice : TeaModel {
                public long? LoginTime { get; set; }
                public string ClientPort { get; set; }
                public string Remark { get; set; }
                public string BrowserVersion { get; set; }
                public string ClientIp { get; set; }
                public string InstanceId { get; set; }
                public int? IsLogin { get; set; }
                public long? RamId { get; set; }
            }
        };

    }

}

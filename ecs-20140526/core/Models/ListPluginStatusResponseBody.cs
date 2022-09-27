// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListPluginStatusResponseBody : TeaModel {
        [NameInMap("InstancePluginStatusSet")]
        [Validation(Required=false)]
        public ListPluginStatusResponseBodyInstancePluginStatusSet InstancePluginStatusSet { get; set; }
        public class ListPluginStatusResponseBodyInstancePluginStatusSet : TeaModel {
            [NameInMap("InstancePluginStatus")]
            [Validation(Required=false)]
            public List<ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatus> InstancePluginStatus { get; set; }
            public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatus : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PluginStatusSet")]
                [Validation(Required=false)]
                public ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSet PluginStatusSet { get; set; }
                public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSet : TeaModel {
                    [NameInMap("PluginStatus")]
                    [Validation(Required=false)]
                    public List<ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSetPluginStatus> PluginStatus { get; set; }
                    public class ListPluginStatusResponseBodyInstancePluginStatusSetInstancePluginStatusPluginStatusSetPluginStatus : TeaModel {
                        [NameInMap("FirstHeartbeatTime")]
                        [Validation(Required=false)]
                        public string FirstHeartbeatTime { get; set; }

                        [NameInMap("LastHeartbeatTime")]
                        [Validation(Required=false)]
                        public string LastHeartbeatTime { get; set; }

                        [NameInMap("PluginName")]
                        [Validation(Required=false)]
                        public string PluginName { get; set; }

                        [NameInMap("PluginStatus")]
                        [Validation(Required=false)]
                        public string PluginStatus { get; set; }

                        [NameInMap("PluginVersion")]
                        [Validation(Required=false)]
                        public string PluginVersion { get; set; }

                    }

                }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

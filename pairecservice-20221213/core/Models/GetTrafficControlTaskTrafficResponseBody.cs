// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskTrafficResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6CF1E160-3F36-5E73-A170-C75504F05BBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficControlTaskTrafficInfo")]
        [Validation(Required=false)]
        public GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfo TrafficControlTaskTrafficInfo { get; set; }
        public class GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfo : TeaModel {
            [NameInMap("TargetTraffics")]
            [Validation(Required=false)]
            public List<GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfoTargetTraffics> TargetTraffics { get; set; }
            public class GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfoTargetTraffics : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public Dictionary<string, TrafficControlTaskTrafficInfoTargetTrafficsDataValue> Data { get; set; }

                [NameInMap("TrafficControlTargetId")]
                [Validation(Required=false)]
                public string TrafficControlTargetId { get; set; }

            }

            [NameInMap("TaskTraffics")]
            [Validation(Required=false)]
            public Dictionary<string, TrafficControlTaskTrafficInfoTaskTrafficsValue> TaskTraffics { get; set; }

        }

    }

}

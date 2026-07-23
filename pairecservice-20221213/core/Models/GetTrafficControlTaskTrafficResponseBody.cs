// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskTrafficResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF1E160-3F36-5E73-A170-C75504F05BBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the reported traffic data.</para>
        /// </summary>
        [NameInMap("TrafficControlTaskTrafficInfo")]
        [Validation(Required=false)]
        public GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfo TrafficControlTaskTrafficInfo { get; set; }
        public class GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfo : TeaModel {
            /// <summary>
            /// <para>The traffic data for each traffic control target.</para>
            /// </summary>
            [NameInMap("TargetTraffics")]
            [Validation(Required=false)]
            public List<GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfoTargetTraffics> TargetTraffics { get; set; }
            public class GetTrafficControlTaskTrafficResponseBodyTrafficControlTaskTrafficInfoTargetTraffics : TeaModel {
                /// <summary>
                /// <para>The detailed data reported for this traffic control target.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public Dictionary<string, TrafficControlTaskTrafficInfoTargetTrafficsDataValue> Data { get; set; }

                /// <summary>
                /// <para>The traffic control target ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TrafficContorlTargetId")]
                [Validation(Required=false)]
                public string TrafficContorlTargetId { get; set; }

            }

            /// <summary>
            /// <para>The reported traffic data for the traffic control task.</para>
            /// </summary>
            [NameInMap("TaskTraffics")]
            [Validation(Required=false)]
            public Dictionary<string, TrafficControlTaskTrafficInfoTaskTrafficsValue> TaskTraffics { get; set; }

        }

    }

}

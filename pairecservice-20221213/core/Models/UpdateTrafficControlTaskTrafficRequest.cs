// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTaskTrafficRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>learn-pairec-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Traffics")]
        [Validation(Required=false)]
        public List<UpdateTrafficControlTaskTrafficRequestTraffics> Traffics { get; set; }
        public class UpdateTrafficControlTaskTrafficRequestTraffics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>item1</para>
            /// </summary>
            [NameInMap("ItemOrExperimentId")]
            [Validation(Required=false)]
            public string ItemOrExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01T02:05:06.111Z</para>
            /// </summary>
            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("TrafficControlTargetAimTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetAimTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrafficControlTargetId")]
            [Validation(Required=false)]
            public string TrafficControlTargetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TrafficControlTargetTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTargetTraffic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("TrafficControlTaskTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTaskTraffic { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("new-param-3")]
        [Validation(Required=false)]
        public string NewParam3 { get; set; }

    }

}

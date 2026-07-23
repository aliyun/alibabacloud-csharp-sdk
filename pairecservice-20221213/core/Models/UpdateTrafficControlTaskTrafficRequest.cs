// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTaskTrafficRequest : TeaModel {
        /// <summary>
        /// <para>The environment. Valid values: <c>Daily</c> (daily environment), <c>Pre</c> (pre-release environment), and <c>Prod</c> (production environment).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A list of traffic objects to report.</para>
        /// </summary>
        [NameInMap("Traffics")]
        [Validation(Required=false)]
        public List<UpdateTrafficControlTaskTrafficRequestTraffics> Traffics { get; set; }
        public class UpdateTrafficControlTaskTrafficRequestTraffics : TeaModel {
            /// <summary>
            /// <para>The identifier for the traffic object. This can be an item ID, such as <c>item1</c>, an experiment ID, a global identifier (<c>ER_ALL</c>), or a value in <c>L1_EG1_E1</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item1</para>
            /// </summary>
            [NameInMap("ItemOrExperimentId")]
            [Validation(Required=false)]
            public string ItemOrExperimentId { get; set; }

            /// <summary>
            /// <para>The timestamp from the behavior log. This indicates that the log data is current as of this timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T02:05:06.111Z</para>
            /// </summary>
            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            /// <summary>
            /// <para>The configured target traffic for the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("TrafficControlTargetAimTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetAimTraffic { get; set; }

            /// <summary>
            /// <para>The traffic control target ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrafficControlTargetId")]
            [Validation(Required=false)]
            public string TrafficControlTargetId { get; set; }

            /// <summary>
            /// <para>The actual traffic volume observed for the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TrafficControlTargetTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTargetTraffic { get; set; }

            /// <summary>
            /// <para>The total traffic for the traffic control task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("TrafficControlTaskTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTaskTraffic { get; set; }

        }

        /// <summary>
        /// <para>This parameter is invalid and should be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("new-param-3")]
        [Validation(Required=false)]
        public string NewParam3 { get; set; }

    }

}

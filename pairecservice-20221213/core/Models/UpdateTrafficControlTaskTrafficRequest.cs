// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTaskTrafficRequest : TeaModel {
        /// <summary>
        /// <para>The environment to which the task belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: daily environment</description></item>
        /// <item><description>Pre: pre-release environment</description></item>
        /// <item><description>Prod: production environment</description></item>
        /// </list>
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
        /// <para>The list of reported traffic information.</para>
        /// </summary>
        [NameInMap("Traffics")]
        [Validation(Required=false)]
        public List<UpdateTrafficControlTaskTrafficRequestTraffics> Traffics { get; set; }
        public class UpdateTrafficControlTaskTrafficRequestTraffics : TeaModel {
            /// <summary>
            /// <para>The traffic object, which can be an item or an experiment item. Valid values: item1, ER_ALL (global), or a value in the L1_EG1_E1 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item1</para>
            /// </summary>
            [NameInMap("ItemOrExperimentId")]
            [Validation(Required=false)]
            public string ItemOrExperimentId { get; set; }

            /// <summary>
            /// <para>The timestamp from the behavior log, indicating the log cutoff time. The value is in ISO 8601 format, using Z to indicate the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T02:05:06.111Z</para>
            /// </summary>
            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            /// <summary>
            /// <para>The target traffic of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("TrafficControlTargetAimTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetAimTraffic { get; set; }

            /// <summary>
            /// <para>The ID of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TrafficControlTargetId")]
            [Validation(Required=false)]
            public string TrafficControlTargetId { get; set; }

            /// <summary>
            /// <para>The actual traffic of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TrafficControlTargetTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTargetTraffic { get; set; }

            /// <summary>
            /// <para>The overall traffic under the traffic control plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("TrafficControlTaskTraffic")]
            [Validation(Required=false)]
            public long? TrafficControlTaskTraffic { get; set; }

        }

        /// <summary>
        /// <para>Invalid parameter. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("new-param-3")]
        [Validation(Required=false)]
        public string NewParam3 { get; set; }

    }

}

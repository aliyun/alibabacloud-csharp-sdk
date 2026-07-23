// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTargetTrafficHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of historical records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>A list of the traffic control history records.</para>
        /// </summary>
        [NameInMap("TrafficControlTaskTrafficHistories")]
        [Validation(Required=false)]
        public List<ListTrafficControlTargetTrafficHistoryResponseBodyTrafficControlTaskTrafficHistories> TrafficControlTaskTrafficHistories { get; set; }
        public class ListTrafficControlTargetTrafficHistoryResponseBodyTrafficControlTaskTrafficHistories : TeaModel {
            /// <summary>
            /// <para>The ID of the experiment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E1</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <para>The ID of the item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The timestamp of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-10 10:10:58</para>
            /// </summary>
            [NameInMap("RecordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            /// <summary>
            /// <para>The intended traffic for the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TrafficControlTargetAimTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetAimTraffic { get; set; }

            /// <summary>
            /// <para>The actual traffic of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TrafficControlTargetTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTargetTraffic { get; set; }

            /// <summary>
            /// <para>The overall traffic of the traffic control task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TrafficControlTaskTraffic")]
            [Validation(Required=false)]
            public double? TrafficControlTaskTraffic { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryTrafficControlTaskItemReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of item control reports.</para>
        /// </summary>
        [NameInMap("TrafficControlTaskItemReports")]
        [Validation(Required=false)]
        public List<QueryTrafficControlTaskItemReportResponseBodyTrafficControlTaskItemReports> TrafficControlTaskItemReports { get; set; }
        public class QueryTrafficControlTaskItemReportResponseBodyTrafficControlTaskItemReports : TeaModel {
            /// <summary>
            /// <para>The actual number of controlled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ActualItemControlNum")]
            [Validation(Required=false)]
            public long? ActualItemControlNum { get; set; }

            /// <summary>
            /// <para>The actual traffic of controlled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ActualItemControlTraffic")]
            [Validation(Required=false)]
            public long? ActualItemControlTraffic { get; set; }

            /// <summary>
            /// <para>The number of items that reached the control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("DoneItemControlNum")]
            [Validation(Required=false)]
            public long? DoneItemControlNum { get; set; }

            /// <summary>
            /// <para>The number of items that reached the control target, as a percentage of the expected number of controlled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20%</para>
            /// </summary>
            [NameInMap("DoneItemControlPercentage")]
            [Validation(Required=false)]
            public string DoneItemControlPercentage { get; set; }

            /// <summary>
            /// <para>The actual number of controlled items as a percentage of the expected number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10%</para>
            /// </summary>
            [NameInMap("ItemControlNumPercentage")]
            [Validation(Required=false)]
            public string ItemControlNumPercentage { get; set; }

            /// <summary>
            /// <para>The actual traffic from controlled items as a percentage of the expected traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20%</para>
            /// </summary>
            [NameInMap("ItemControlTrafficPercentage")]
            [Validation(Required=false)]
            public string ItemControlTrafficPercentage { get; set; }

            /// <summary>
            /// <para>The expected number of controlled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OughtItemControlNum")]
            [Validation(Required=false)]
            public long? OughtItemControlNum { get; set; }

            /// <summary>
            /// <para>The expected traffic of controlled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("OughtItemControlTraffic")]
            [Validation(Required=false)]
            public long? OughtItemControlTraffic { get; set; }

            /// <summary>
            /// <para>The ID of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TrafficControlTargetId")]
            [Validation(Required=false)]
            public string TrafficControlTargetId { get; set; }

            /// <summary>
            /// <para>The name of the traffic control target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item-1</para>
            /// </summary>
            [NameInMap("TrafficControlTargetName")]
            [Validation(Required=false)]
            public string TrafficControlTargetName { get; set; }

        }

    }

}

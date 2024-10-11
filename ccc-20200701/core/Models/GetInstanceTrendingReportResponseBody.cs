// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetInstanceTrendingReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceTrendingReportResponseBodyData Data { get; set; }
        public class GetInstanceTrendingReportResponseBodyData : TeaModel {
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataInbound> Inbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataInbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInIVR")]
                [Validation(Required=false)]
                public long? CallsAbandonedInIVR { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1604639129000</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

            }

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataOutbound> Outbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1604639129000</para>
                /// </summary>
                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

            }

            [NameInMap("Overall")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataOverall> Overall { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataOverall : TeaModel {
                [NameInMap("MaxLoggedInAgents")]
                [Validation(Required=false)]
                public long? MaxLoggedInAgents { get; set; }

                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

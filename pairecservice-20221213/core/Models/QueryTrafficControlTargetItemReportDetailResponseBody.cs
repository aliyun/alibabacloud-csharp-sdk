// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryTrafficControlTargetItemReportDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficControlTargetItemReportDetail")]
        [Validation(Required=false)]
        public QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetail TrafficControlTargetItemReportDetail { get; set; }
        public class QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetail : TeaModel {
            [NameInMap("ItemControlTailReportDetails")]
            [Validation(Required=false)]
            public List<QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTailReportDetails> ItemControlTailReportDetails { get; set; }
            public class QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTailReportDetails : TeaModel {
                [NameInMap("Features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>794872809896</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>49%</para>
                /// </summary>
                [NameInMap("TargetProgress")]
                [Validation(Required=false)]
                public string TargetProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TargetTraffic")]
                [Validation(Required=false)]
                public long? TargetTraffic { get; set; }

            }

            [NameInMap("ItemControlTopReportDetails")]
            [Validation(Required=false)]
            public List<QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTopReportDetails> ItemControlTopReportDetails { get; set; }
            public class QueryTrafficControlTargetItemReportDetailResponseBodyTrafficControlTargetItemReportDetailItemControlTopReportDetails : TeaModel {
                [NameInMap("Features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>398734</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>49%</para>
                /// </summary>
                [NameInMap("TargetProgress")]
                [Validation(Required=false)]
                public string TargetProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TargetTraffic")]
                [Validation(Required=false)]
                public long? TargetTraffic { get; set; }

            }

        }

    }

}

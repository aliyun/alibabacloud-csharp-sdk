// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnReportListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the report that is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;data&quot;:[{&quot;reportId&quot;:1,&quot;deliver&quot;:{&quot;report&quot;:{&quot;title&quot;:&quot;DomainPvUv&quot;,&quot;format&quot;:&quot;chart&quot;,&quot;shape&quot;:&quot;line&quot;,&quot;xAxis&quot;:&quot;ds&quot;,&quot;yAxis&quot;:&quot;cnt&quot;,&quot;legend&quot;:&quot;cnt_type&quot;,&quot;header&quot;:[&quot;ds&quot;,&quot;cnt_type&quot;,&quot;cnt&quot;]}}}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeCdnReportListResponseBodyContent Content { get; set; }
        public class DescribeCdnReportListResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<DescribeCdnReportListResponseBodyContentData> Data { get; set; }
            public class DescribeCdnReportListResponseBodyContentData : TeaModel {
                [NameInMap("deliver")]
                [Validation(Required=false)]
                public DescribeCdnReportListResponseBodyContentDataDeliver Deliver { get; set; }
                public class DescribeCdnReportListResponseBodyContentDataDeliver : TeaModel {
                    [NameInMap("report")]
                    [Validation(Required=false)]
                    public DescribeCdnReportListResponseBodyContentDataDeliverReport Report { get; set; }
                    public class DescribeCdnReportListResponseBodyContentDataDeliverReport : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table</para>
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("header")]
                        [Validation(Required=false)]
                        public List<string> Header { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("outLine")]
                        [Validation(Required=false)]
                        public long? OutLine { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("outSize")]
                        [Validation(Required=false)]
                        public long? OutSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>line</para>
                        /// </summary>
                        [NameInMap("shape")]
                        [Validation(Required=false)]
                        public string Shape { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TopUrlByAcc</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("reportId")]
                [Validation(Required=false)]
                public long? ReportId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

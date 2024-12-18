// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRulesReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the compliance evaluation report.</para>
        /// </summary>
        [NameInMap("ConfigRulesReport")]
        [Validation(Required=false)]
        public GetAggregateConfigRulesReportResponseBodyConfigRulesReport ConfigRulesReport { get; set; }
        public class GetAggregateConfigRulesReportResponseBodyConfigRulesReport : TeaModel {
            /// <summary>
            /// <para>The ID of the management account to which the rules belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-f632626622af0079****</para>
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// <para>The timestamp when the compliance evaluation report was generated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624332329593</para>
            /// </summary>
            [NameInMap("ReportCreateTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the compliance evaluation report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crp-88176457e0d900c9****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The status of the compliance evaluation report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: The compliance evaluation report was not generated.</description></item>
            /// <item><description>CREATING: The compliance evaluation report was being generated.</description></item>
            /// <item><description>COMPLETE: The compliance evaluation report was generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the compliance evaluation report.</para>
            /// </summary>
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0BCC7B2-D0E4-49B0-95D2-6689CFB08D31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

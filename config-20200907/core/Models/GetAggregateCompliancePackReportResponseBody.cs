// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateCompliancePackReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance evaluation report that is generated based on a compliance package.</para>
        /// </summary>
        [NameInMap("CompliancePackReport")]
        [Validation(Required=false)]
        public GetAggregateCompliancePackReportResponseBodyCompliancePackReport CompliancePackReport { get; set; }
        public class GetAggregateCompliancePackReportResponseBodyCompliancePackReport : TeaModel {
            /// <summary>
            /// <para>The ID of the management account to which the compliance package belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-fdc8626622af00f9****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The timestamp when the compliance evaluation report was generated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624330246640</para>
            /// </summary>
            [NameInMap("ReportCreateTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateTimestamp { get; set; }

            /// <summary>
            /// <para>The status of the compliance evaluation report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NONE: The compliance evaluation report is not generated.</description></item>
            /// <item><description>CREATING: The compliance evaluation report is being generated.</description></item>
            /// <item><description>COMPLETE: The compliance evaluation report is generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
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
        /// <para>0D234DAC-1ABD-42E8-9475-BE317857E29B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

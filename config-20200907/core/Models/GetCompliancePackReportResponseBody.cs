// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetCompliancePackReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the compliance evaluation report.</para>
        /// </summary>
        [NameInMap("CompliancePackReport")]
        [Validation(Required=false)]
        public GetCompliancePackReportResponseBodyCompliancePackReport CompliancePackReport { get; set; }
        public class GetCompliancePackReportResponseBodyCompliancePackReport : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the compliance package belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
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
            /// <para>1624329965857</para>
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
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

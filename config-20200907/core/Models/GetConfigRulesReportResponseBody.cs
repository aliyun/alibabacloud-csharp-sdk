// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRulesReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the compliance evaluation report.</para>
        /// </summary>
        [NameInMap("ConfigRulesReport")]
        [Validation(Required=false)]
        public GetConfigRulesReportResponseBodyConfigRulesReport ConfigRulesReport { get; set; }
        public class GetConfigRulesReportResponseBodyConfigRulesReport : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the rules belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The timestamp when the compliance evaluation report was generated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614687022000</para>
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
            /// <item><description>NONE: The compliance evaluation report is not generated.</description></item>
            /// <item><description>CREATING: The compliance evaluation report is being generated.</description></item>
            /// <item><description>COMPLETE: The compliance evaluation report is generated.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

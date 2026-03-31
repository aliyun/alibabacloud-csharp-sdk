// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetReportTemplateResponseBody : TeaModel {
        [NameInMap("ReportTemplate")]
        [Validation(Required=false)]
        public GetReportTemplateResponseBodyReportTemplate ReportTemplate { get; set; }
        public class GetReportTemplateResponseBodyReportTemplate : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>excel</para>
            /// </summary>
            [NameInMap("ReportFileFormats")]
            [Validation(Required=false)]
            public string ReportFileFormats { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AllInOne</para>
            /// </summary>
            [NameInMap("ReportGranularity")]
            [Validation(Required=false)]
            public string ReportGranularity { get; set; }

            [NameInMap("ReportLanguage")]
            [Validation(Required=false)]
            public string ReportLanguage { get; set; }

            [NameInMap("ReportScope")]
            [Validation(Required=false)]
            public List<GetReportTemplateResponseBodyReportTemplateReportScope> ReportScope { get; set; }
            public class GetReportTemplateResponseBodyReportTemplateReportScope : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RuleId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>In</para>
                /// </summary>
                [NameInMap("MatchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cr-1,cr-2</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-description</para>
            /// </summary>
            [NameInMap("ReportTemplateDescription")]
            [Validation(Required=false)]
            public string ReportTemplateDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crt-xxx</para>
            /// </summary>
            [NameInMap("ReportTemplateId")]
            [Validation(Required=false)]
            public string ReportTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("ReportTemplateName")]
            [Validation(Required=false)]
            public string ReportTemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 0 * * ?</para>
            /// </summary>
            [NameInMap("SubscriptionFrequency")]
            [Validation(Required=false)]
            public string SubscriptionFrequency { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7A0FFF8-0B44-40C6-8BBF-3A185EFDF3F7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

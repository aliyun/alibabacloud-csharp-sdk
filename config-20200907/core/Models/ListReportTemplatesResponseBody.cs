// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListReportTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aVCjqNaSy0Ps7zSMGu25****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ReportTemplateList")]
        [Validation(Required=false)]
        public List<ListReportTemplatesResponseBodyReportTemplateList> ReportTemplateList { get; set; }
        public class ListReportTemplatesResponseBodyReportTemplateList : TeaModel {
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
            public List<ListReportTemplatesResponseBodyReportTemplateListReportScope> ReportScope { get; set; }
            public class ListReportTemplatesResponseBodyReportTemplateListReportScope : TeaModel {
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
            /// <para>0 0 13 * * ?</para>
            /// </summary>
            [NameInMap("SubscriptionFrequency")]
            [Validation(Required=false)]
            public string SubscriptionFrequency { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8195B664-9565-4685-89AC-8B5F04B44B92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateReportTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>excel</para>
        /// </summary>
        [NameInMap("ReportFileFormats")]
        [Validation(Required=false)]
        public string ReportFileFormats { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ReportGranularity</para>
        /// </summary>
        [NameInMap("ReportGranularity")]
        [Validation(Required=false)]
        public string ReportGranularity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ReportLanguage")]
        [Validation(Required=false)]
        public string ReportLanguage { get; set; }

        [NameInMap("ReportScope")]
        [Validation(Required=false)]
        public List<CreateReportTemplateRequestReportScope> ReportScope { get; set; }
        public class CreateReportTemplateRequestReportScope : TeaModel {
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
        /// <para>test-report-description</para>
        /// </summary>
        [NameInMap("ReportTemplateDescription")]
        [Validation(Required=false)]
        public string ReportTemplateDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-report-name</para>
        /// </summary>
        [NameInMap("ReportTemplateName")]
        [Validation(Required=false)]
        public string ReportTemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0 0 9 * * ?</para>
        /// </summary>
        [NameInMap("SubscriptionFrequency")]
        [Validation(Required=false)]
        public string SubscriptionFrequency { get; set; }

    }

}

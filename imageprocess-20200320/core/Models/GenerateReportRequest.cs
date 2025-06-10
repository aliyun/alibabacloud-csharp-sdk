// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class GenerateReportRequest : TeaModel {
        [NameInMap("ReportConfigs")]
        [Validation(Required=false)]
        public List<GenerateReportRequestReportConfigs> ReportConfigs { get; set; }
        public class GenerateReportRequestReportConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CalcBMD</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dark</para>
            /// </summary>
            [NameInMap("Theme")]
            [Validation(Required=false)]
            public string Theme { get; set; }

        }

    }

}

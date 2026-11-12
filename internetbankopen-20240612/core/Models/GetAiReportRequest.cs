// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class GetAiReportRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>call-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
        /// </summary>
        [NameInMap("callId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}

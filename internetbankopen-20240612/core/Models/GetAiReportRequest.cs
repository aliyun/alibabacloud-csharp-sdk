// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class GetAiReportRequest : TeaModel {
        /// <summary>
        /// <para>The data call ID, which is obtained from the callId returned by InvokeDataProduct. You must specify either this parameter or reportId. You cannot specify both or leave both empty. The value must start with call- and be 1 to 64 characters in length. It can contain only ASCII letters, digits, underscores (_), and hyphens (-). The value is case-sensitive, and leading and trailing spaces are not trimmed. If the format is invalid, InvalidParameter.CallId is returned. If both parameters are specified or left empty, InvalidParameter.ReportReference is returned. This parameter is used to query the status of per-use reports. If you use this ID to query a periodic report, WAITING_PERIOD is always returned. Use the ReportId from the list instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>call-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
        /// </summary>
        [NameInMap("callId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The report ID, which is obtained from the ReportId returned by ListProductReports or the Report.ReportId in the previous available result of GetAiReport. You must specify either this parameter or callId. You cannot specify both or leave both empty. The value must start with report- and be 1 to 64 characters in length. It can contain only ASCII letters, digits, underscores (_), and hyphens (-). The value is case-sensitive, and leading and trailing spaces are not trimmed. If the format is invalid, InvalidParameter.ReportId is returned. If both parameters are specified or left empty, InvalidParameter.ReportReference is returned. You can only query reports that belong to the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveCustomizeReportConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The report ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11472B29-1A1C-5D7F-944B-7CD84319****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

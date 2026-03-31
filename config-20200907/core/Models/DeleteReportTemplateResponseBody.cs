// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteReportTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>crt-xxx</para>
        /// </summary>
        [NameInMap("ReportTemplateId")]
        [Validation(Required=false)]
        public string ReportTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DE9FFFE5-FCAD-4B24-9546-BF49273C562B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

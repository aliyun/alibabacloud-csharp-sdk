// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateReportTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>crt-xxx</para>
        /// </summary>
        [NameInMap("ReportTemplateId")]
        [Validation(Required=false)]
        public string ReportTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7A0FFF8-0B44-40C6-8BBF-3A185EFDFXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetPipelineScanReportUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/test/test.html</para>
        /// </summary>
        [NameInMap("reportPath")]
        [Validation(Required=false)]
        public string ReportPath { get; set; }

    }

}

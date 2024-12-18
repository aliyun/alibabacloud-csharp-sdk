// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRulesReportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compliance evaluation report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crp-88176457e0d900c9****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}

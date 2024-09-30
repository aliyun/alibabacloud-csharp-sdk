// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GenerateConfigRuleReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the resource non-compliance report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crp-ao0786618088006c****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37B2AC06-89D8-5D95-98DF-3E68C12BDE05</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

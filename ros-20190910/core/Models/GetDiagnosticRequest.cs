// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetDiagnosticRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the diagnostic report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-d540def087714890****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}

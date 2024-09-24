// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DeleteDiagnosticRequest : TeaModel {
        /// <summary>
        /// <para>The report ID. You can troubleshoot issues based on the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-56a0e30bf9854b00****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}

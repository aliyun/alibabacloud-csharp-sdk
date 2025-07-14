// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GenerateGovernanceReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>492E130C-76D3-55D5-BE5C-C023E431369A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The report generation status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Started: The system starts to generate a governance report.</description></item>
        /// <item><description>Progressing: The system is generating a governance report.</description></item>
        /// <item><description>Completed: A governance report is generated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Started</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

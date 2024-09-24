// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The severities of the alert events handled by the virus detection task. Separate multiple severities with commas (,). The severities decrease in descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>serious</b></description></item>
        /// <item><description><b>suspicious</b></description></item>
        /// <item><description><b>remind</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>serious,suspicious,remind</para>
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

    }

}

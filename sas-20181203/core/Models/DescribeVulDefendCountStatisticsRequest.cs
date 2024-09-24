// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDefendCountStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>app: application vulnerabilities</description></item>
        /// <item><description>emg: urgent vulnerabilities</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>emg</para>
        /// </summary>
        [NameInMap("VulType")]
        [Validation(Required=false)]
        public string VulType { get; set; }

    }

}

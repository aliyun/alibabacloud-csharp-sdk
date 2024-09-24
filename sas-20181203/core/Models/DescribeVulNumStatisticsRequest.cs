// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulNumStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The source of the request.</para>
        /// <list type="bullet">
        /// <item><description>If you want to query Security Center-related data, set the value to <b>sas</b>.</description></item>
        /// <item><description>If you want to query Server Guard-related data, you do not need to specify this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

    }

}

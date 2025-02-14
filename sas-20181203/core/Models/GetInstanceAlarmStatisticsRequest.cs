// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInstanceAlarmStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The data source for statistics on instance alarms, with a default value of aqs:</para>
        /// <list type="bullet">
        /// <item><description><em>sas</em>: Situation Awareness data source</description></item>
        /// <item><description><em>aqs</em>: Alarm event data</description></item>
        /// <item><description><em>honeypot</em>: Honeypot</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The UUID of the server to be queried.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> API to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>00fea5a1-9792-4373-ab1e-bb6536ba****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}

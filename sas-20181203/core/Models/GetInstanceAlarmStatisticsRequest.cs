// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInstanceAlarmStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The data source from which instance alert statistics are collected. Default value: aqs.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sas</b>: Threat Detection Service data source.</description></item>
        /// <item><description><b>aqs</b>: alert event data.</description></item>
        /// <item><description><b>honeypot</b>: cloud honeypot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
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

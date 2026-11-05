// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendRequest : TeaModel {
        /// <summary>
        /// <para>The security data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HC_NEW</b>: the number of new baseline risks</description></item>
        /// <item><description><b>HC_OPERATE</b>: the number of handled baseline risks</description></item>
        /// <item><description><b>VUL_NEW</b>: the number of new vulnerability risks</description></item>
        /// <item><description><b>VUL_OPERATE</b>: the number of handled vulnerability risks</description></item>
        /// <item><description><b>SUSP_NEW</b>: the number of new alerts</description></item>
        /// <item><description><b>SUSP_OPERATE</b>: the number of handled alerts</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify multiple values separated by commas (,). Example: HC_NEW,VUL_NEW.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HC_NEW,HC_OPERATE</para>
        /// </summary>
        [NameInMap("BizTypes")]
        [Validation(Required=false)]
        public string BizTypes { get; set; }

        /// <summary>
        /// <para>The end timestamp of the query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The value of StartTimestamp must be earlier than the value of EndTimestamp. Otherwise, the API returns HTTP 400 and the error code -101.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721923200000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The interval for querying data. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The minimum value is 1000. A maximum of 100 data points are returned. Excess data points are not returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of member accounts in the resource folder.</para>
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
        /// <para>The start timestamp of the query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687334501000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}

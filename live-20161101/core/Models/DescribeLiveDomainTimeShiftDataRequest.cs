// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTimeShiftDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain to query.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you specify DomainName, make sure that the specified domain is a live streaming domain and that the user calling this operation has permissions on the specified domain.</description></item>
        /// <item><description>You can specify a single domain or multiple domains. Separate multiple domains with commas (,).</description></item>
        /// <item><description>If this parameter is left empty, the merged data of all live streaming domains is returned by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-03T02:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the queried data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><ol start="300">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3600">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="86400">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter or specify an unsupported value, the default value 300 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The minimum data granularity is 5 minutes.</description></item>
        /// <item><description>If you do not specify this parameter, data of the last 24 hours is returned by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-03T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

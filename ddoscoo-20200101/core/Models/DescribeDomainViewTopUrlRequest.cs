// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewTopUrlRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website service.</para>
        /// <remarks>
        /// <para>The domain name must have a website service forwarding rule configured. You can invoke <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names that are added to Anti-DDoS Pro and Anti-DDoS Premium.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>The value must be on the exact minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583683200</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The step size for returning data, in seconds. This parameter specifies the interval at which a result is returned. The supported step size varies based on the query time range (determined by <b>StartTime</b> and <b>EndTime</b>). Recommended settings:</para>
        /// <list type="bullet">
        /// <item><description>Query time range of up to 1 hour: minimum step size of 60 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range of more than 1 hour but up to 6 hours: minimum step size of 600 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range of more than 6 hours but up to 24 hours: minimum step size of 1800 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range of more than 24 hours but up to 7 days: minimum step size of 3600 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range of more than 7 days but up to 15 days: minimum step size of 14400 seconds, maximum not exceeding the query time range.</description></item>
        /// <item><description>Query time range of more than 15 days: minimum step size of 43200 seconds, maximum not exceeding the query time range.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Inerval")]
        [Validation(Required=false)]
        public long? Inerval { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro or Anti-DDoS Premium instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify a UNIX timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>The value must be on the exact minute.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582992000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The number of URLs to return. Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public int? Top { get; set; }

    }

}

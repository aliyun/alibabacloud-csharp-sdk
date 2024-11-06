// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainTopUrlVisitRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify only one domain name in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>traf</b>: by network traffic</description></item>
        /// <item><description><b>pv</b>: by the number of visits</description></item>
        /// </list>
        /// <para>Default value: <b>pv</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>pv</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>To query the data on a specified day, use the format: yyyy-MM-ddT16:00:00Z.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the data in the last 24 hours is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

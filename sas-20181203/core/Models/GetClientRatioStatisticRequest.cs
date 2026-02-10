// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientRatioStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the primary account of the Resource Directory member account.</para>
        /// <remarks>
        /// <para>call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> interface to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>An array that consists of the details of a statistical type.</para>
        /// </summary>
        [NameInMap("StatisticTypes")]
        [Validation(Required=false)]
        public List<string> StatisticTypes { get; set; }

        /// <summary>
        /// <para>The timestamp that specifies the end of the time range to collect statistics. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1686412799999</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// <para>The timestamp that specifies the beginning of the time range to collect statistics. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671382800000</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainMultiUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>If this parameter is not set, data of all your accelerated domain names is queried.</para>
        /// <para>You can specify multiple domain names and separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time must be later than the start time.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</description></item>
        /// <item><description>You need to set both the start time and the end time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <list type="bullet">
        /// <item><description>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</description></item>
        /// <item><description>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</description></item>
        /// <item><description>The resolution of the queried data is 5 minutes.</description></item>
        /// <item><description>If you do not set this parameter, data in the last 24 hours is queried.</description></item>
        /// <item><description>You need to set both the start time and the end time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

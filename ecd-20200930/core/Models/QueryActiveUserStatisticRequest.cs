// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryActiveUserStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The business channel type code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1 (default): Enterprise Edition.</description></item>
        /// <item><description>3: Cloud Office.</description></item>
        /// <item><description>10: Standard Edition.</description></item>
        /// <item><description>20: Business Edition.</description></item>
        /// <item><description>30: Education Business Edition.</description></item>
        /// <item><description>40: Cloud Phone isolated resources.</description></item>
        /// <item><description>50: AgentBay.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The end time of the query. The format is the same as StartTime. If the value is later than the current time, it is automatically truncated to the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-01T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The workspace ID. If specified, only active users of cloud desktops in this workspace are counted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-885351****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The aggregation interval for statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ONE_MINUTE: 1 minute.</description></item>
        /// <item><description>TWO_MINUTE: 2 minutes.</description></item>
        /// <item><description>FIVE_MINUTE (default): 5 minutes.</description></item>
        /// <item><description>ONE_HOUR: 1 hour.</description></item>
        /// <item><description>ONE_DAY: 1 day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FIVE_MINUTE</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The start time of the query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UTC format: yyyy-MM-ddTHH:mm:ssZ.</description></item>
        /// <item><description>Standard format: yyyy-MM-dd HH:mm:ss.</description></item>
        /// </list>
        /// <para>The value cannot be earlier than 6 months before the current time or later than EndTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

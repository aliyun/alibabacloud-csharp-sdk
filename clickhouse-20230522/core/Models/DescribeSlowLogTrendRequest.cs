// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeSlowLogTrendRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp100p4q1g9z3****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-dd hh:mm:ss format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-07 10:03:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The code of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clickhouse</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The execution duration of slow SQL queries. Minimum value: <b>1000</b>. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("QueryDurationMs")]
        [Validation(Required=false)]
        public string QueryDurationMs { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the yyyy-MM-dd hh:mm:ss format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-13 17:48:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageTotalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource ownership account. The resource ownership account is the account that actually uses the resource. Only one account ID can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end time. Format: yyyy-MM-dd HH:mm:ss. The query excludes data at this time. If this parameter is left empty, the query range extends to the current time. This value specifies the end time of the query range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        /// <summary>
        /// <para>The time granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTH: month</description></item>
        /// <item><description>DAY: day</description></item>
        /// <item><description>HOUR: hour</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The resource plan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RI: reserved instance.</description></item>
        /// <item><description>SCU: storage capacity unit.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RI</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The start time. Format: yyyy-MM-dd HH:mm:ss. The query includes data at this time. This value specifies the start time of the query range.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

    }

}

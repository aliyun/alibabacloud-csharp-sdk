// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageTotalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account whose data you want to query. If you do not specify this parameter, the data of the current account and its linked accounts is queried. To query the data of a linked account, specify the ID of the linked account. You can specify only one account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format. The specified time is excluded from the time range. If you do not specify this parameter, this parameter is set to the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        /// <summary>
        /// <para>The time granularity at which the data is queried. Valid values: MONTH, DAY, and HOUR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// <para>The type of the resource plan. Valid values: RI and SCU.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RI</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format. The specified time is included in the time range.</para>
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

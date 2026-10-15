// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account whose data you want to query. If this parameter is left empty, the data of the current account and its trusteeship linked accounts is queried. You can specify the ID of a trusteeship linked account to query only the data of that account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: yyyy-MM-dd HH:mm:ss. The specified time is excluded from the query. If this parameter is left empty, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single request. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty when you query the first page. The token for the next page is returned in the response. If the returned token is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The time granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTH: Monthly.</description></item>
        /// <item><description>DAY: Daily.</description></item>
        /// <item><description>HOUR: Hourly.</description></item>
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
        /// <para>The type of the resource plan. Valid values:</para>
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
        /// <para>The start time of the query. Format: yyyy-MM-dd HH:mm:ss. The specified time is included in the query.</para>
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

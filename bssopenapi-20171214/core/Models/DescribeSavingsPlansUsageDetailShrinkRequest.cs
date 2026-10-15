// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansUsageDetailShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account. If this parameter is left empty, data of the current account and its trusteeship linked accounts is queried. You can specify a trusteeship linked account ID to query data of that account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123745698925000</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The end time. Format: yyyy-MM-dd HH:mm:ss. The query excludes data at this time. If this parameter is left empty, the query covers data up to the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-02 00:00:00</para>
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        [NameInMap("FilterParam")]
        [Validation(Required=false)]
        public string FilterParamShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to return. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The time granularity for querying usage details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTH: monthly granularity.</description></item>
        /// <item><description>DAY: daily granularity.</description></item>
        /// <item><description>HOUR: hourly granularity.</description></item>
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
        /// <para>The start time. Format: yyyy-MM-dd HH:mm:ss. The query includes data at this time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first page. The query result returns the token for the next page. If the returned token is empty, all data has been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}

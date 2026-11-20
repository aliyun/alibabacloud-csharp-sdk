// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryModelUsageInfoRequest : TeaModel {
        /// <summary>
        /// <para>The business type. This parameter is required and has no default value. The mapping between business types and valid values is as follows:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: Enterprise Edition.</description></item>
        /// <item><description><c>10</c>: Personal Edition.</description></item>
        /// <item><description><c>20</c>: Commercial Edition.</description></item>
        /// <item><description><c>70</c>: Agentic Computer.</description></item>
        /// </list>
        /// <para><b>The API directly queries the model usage of the current account based on the specified <c>BizType</c> and does not automatically convert or replace the business type.</b> To query the usage of the Agentic Computer business, you must explicitly set <c>BizType</c> to <c>70</c>. The usage of different business types is calculated separately.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The end date of the custom query. The format is <c>yyyy-MM-dd</c>. The date is interpreted as a calendar day in the Asia/Shanghai (UTC+8) time zone and includes the current day. The value is a date string and does not include hours, minutes, seconds, or a time zone suffix.</para>
        /// <para><b>This parameter can be specified only when <c>StatDateType</c> is set to <c>1d</c>, and it must be specified or omitted together with <c>StartDate</c>.</b> The end date cannot be earlier than the start date. The total number of days, including the start and end dates, cannot exceed 90. If you do not use a custom date, omit these two parameters directly. Do not pass empty strings or pure whitespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The model type filter. If this parameter is not specified or an empty string is passed, no filtering by type is performed. The value is case-insensitive:</para>
        /// <list type="bullet">
        /// <item><description><c>LLM</c>: Large language model.</description></item>
        /// <item><description><c>IMAGE</c>: Image model.</description></item>
        /// <item><description><c>VIDEO</c>: Video model.</description></item>
        /// <item><description><c>AUDIO</c>: Audio model.</description></item>
        /// <item><description><c>EMBEDDING</c>: Embedding model.</description></item>
        /// </list>
        /// <para>Non-empty values do not support leading or trailing spaces. Other non-empty values besides the preceding ones will cause parameter validation to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The start date of the custom query. The format is <c>yyyy-MM-dd</c>. The date is interpreted as a calendar day in the Asia/Shanghai (UTC+8) time zone and includes the current day. The value is a date string and does not include hours, minutes, seconds, or a time zone suffix.</para>
        /// <para><b>This parameter can be specified only when <c>StatDateType</c> is set to <c>1d</c>, and it must be specified or omitted together with <c>EndDate</c>.</b> The start date cannot be later than the end date. The total number of days, including the start and end dates, must be between 1 and 90. If both parameters are omitted, the cumulative usage for today is queried. If you do not use a custom date, omit these two parameters directly. Do not pass empty strings or pure whitespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical window. This parameter is required and has no default value. The value is case-sensitive and does not support leading or trailing spaces. Time boundaries are calculated based on <b>Asia/Shanghai (UTC+8)</b>.</para>
        /// <list type="bullet">
        /// <item><description><c>24h</c>: The last 24 hours up to the most recent available statistical cutoff time. The statistical cutoff time corresponds to the current hour or the previous hour.</description></item>
        /// <item><description><c>1d</c>: If the start and end dates are not specified, the cumulative usage for today is queried. If both <c>StartDate</c> and <c>EndDate</c> are specified, the specified calendar day range is queried.</description></item>
        /// <item><description><c>1w</c>: The last 7 days up to the day of the request. If the statistical results for the current day are unavailable, the results from the previous day are not used.</description></item>
        /// <item><description><c>30d</c>: The last 30 days up to the day of the request. If the statistical results for the current day are unavailable, the results from the previous day are not used.</description></item>
        /// <item><description><c>1y</c>: The statistical results for the last 365 days. If the results for the current year are unavailable, the statistical results for the previous year may be returned, and the actual coverage may be earlier than the day of the request. This API does not return the statistical cutoff time for this result, and you cannot use it to confirm that the data has been updated to the current day.</description></item>
        /// </list>
        /// <para><b>Only <c>1d</c> supports custom date ranges</b>. Do not specify start and end dates for other windows.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d</para>
        /// </summary>
        [NameInMap("StatDateType")]
        [Validation(Required=false)]
        public string StatDateType { get; set; }

    }

}

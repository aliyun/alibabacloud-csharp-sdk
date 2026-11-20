// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryModelUsageListRequest : TeaModel {
        /// <summary>
        /// <para>The business type. This parameter is required and has no default value. The mapping between business types and valid values is as follows:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: Enterprise Edition.</description></item>
        /// <item><description><c>10</c>: Personal Edition.</description></item>
        /// <item><description><c>20</c>: Commercial Edition.</description></item>
        /// <item><description><c>70</c>: Agentic Computer.</description></item>
        /// </list>
        /// <para><b>The API operation directly queries the model usage of the current account based on the passed <c>BizType</c> and does not automatically convert or replace the business type.</b> When querying the usage of the Agentic Computer business, you must explicitly pass <c>BizType=70</c>. The usage of different business types is counted separately.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The end date of the custom query. The format is <c>yyyy-MM-dd</c>. It is interpreted as a calendar day in the Asia/Shanghai (UTC+8) time zone and includes the current day. The value is a date string and does not contain hours, minutes, seconds, or a time zone suffix.</para>
        /// <para><b>This parameter can be passed only when <c>StatDateType</c> is set to <c>1d</c>, and it must be passed or omitted together with <c>StartDate</c>.</b> The end date cannot be earlier than the start date. The total number of days, including the start and end dates, must not exceed 90. When custom dates are not used, omit these two parameters directly. Do not pass empty strings or pure whitespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword for the model name or model code. After leading and trailing whitespace is removed, a case-insensitive inclusion match is performed. It is not a regular expression. If this parameter is not passed or is completely whitespace, no filtering by keyword is performed. If it is passed together with <c>ModelType</c>, both conditions take effect simultaneously.</para>
        /// <para>The translated display names of some models do not participate in name matching. When you need to stably locate a model, we recommend that you use the returned <c>LlmCode</c> as the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The display language for models. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>zh-CN</c>: Simplified Chinese.</description></item>
        /// <item><description><c>en-US</c>: English.</description></item>
        /// <item><description><c>ja-JP</c>: Japanese.</description></item>
        /// <item><description><c>zh-TW</c>: Traditional Chinese.</description></item>
        /// </list>
        /// <para>If this parameter is not passed, is empty, or is an unsupported value, <c>zh-CN</c> is used. It is also compatible with <c>zh_CN</c>, <c>en_US</c>, <c>ja_JP</c>, <c>zh_TW</c>, <c>en</c>, and <c>ja</c>, ignoring case and leading or trailing whitespace.</para>
        /// <para>The returned content is not guaranteed to be entirely in the selected language. Some model names and descriptions are provided in Japanese or Traditional Chinese. For other model information, brands, and capability tags, English is used when <c>ja-JP</c> is selected, and Simplified Chinese is used when <c>zh-TW</c> is selected. If the corresponding translation is missing, the existing content is retained. If the model name is missing, the model code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The model type filter condition. If this parameter is not passed or an empty string is passed, no filtering by type is performed. The value is case-insensitive:</para>
        /// <list type="bullet">
        /// <item><description><c>LLM</c>: Large language model.</description></item>
        /// <item><description><c>IMAGE</c>: Image model.</description></item>
        /// <item><description><c>VIDEO</c>: Video model.</description></item>
        /// <item><description><c>AUDIO</c>: Audio model.</description></item>
        /// <item><description><c>EMBEDDING</c>: Embedding model.</description></item>
        /// </list>
        /// <para>Non-empty values do not support leading or trailing spaces. Non-empty values other than the preceding values cause parameter validation to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The page number. It starts from <c>1</c> and the default value is <c>1</c>. It must be an integer greater than or equal to 1. It is used together with <c>PageSize</c> for pagination. If the page number exceeds the range of the filtered results, an empty list is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of models to return per page. The default value is <c>10</c>. Valid values: <c>1</c> to <c>100</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting method. If this parameter is not passed or is empty, the default value is <c>CALL_COUNT_DESC</c>. The value is case-sensitive, and non-empty values do not support leading or trailing spaces:</para>
        /// <list type="bullet">
        /// <item><description><c>CALL_COUNT_DESC</c>: Sort by call count in descending order.</description></item>
        /// <item><description><c>POINTS_CONSUMPTION_DESC</c>: Sort by consumed points in descending order.</description></item>
        /// <item><description><c>SUCCESS_RATE_ASC</c>: Sort by call success rate in ascending order. Models with unavailable success rates are ranked last.</description></item>
        /// <item><description><c>AVG_TTFT_DESC</c>: Sort by average time to first token (TTFT) latency in descending order. Models with unavailable latency are ranked last.</description></item>
        /// </list>
        /// <para>When sorting values are the same, sort by model code <c>LlmCode</c> in ascending order. Filtering and sorting are performed before pagination. Non-empty values other than the preceding values cause parameter validation to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CALL_COUNT_DESC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The start date of the custom query. The format is <c>yyyy-MM-dd</c>. It is interpreted as a calendar day in the Asia/Shanghai (UTC+8) time zone and includes the current day. The value is a date string and does not contain hours, minutes, seconds, or a time zone suffix.</para>
        /// <para><b>This parameter can be passed only when <c>StatDateType</c> is set to <c>1d</c>, and it must be passed or omitted together with <c>EndDate</c>.</b> The start date cannot be later than the end date. The total number of days, including the start and end dates, must be between 1 and 90. If both are omitted, the cumulative usage for today is queried. When custom dates are not used, omit these two parameters directly. Do not pass empty strings or pure whitespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The statistical window. This parameter is required, has no default value, is case-sensitive, and does not support leading or trailing spaces. Time boundaries are calculated based on <b>Asia/Shanghai (UTC+8)</b>.</para>
        /// <list type="bullet">
        /// <item><description><c>24h</c>: The last 24 hours up to the most recent available statistical cutoff time. The statistical cutoff time corresponds to the current hour or the previous hour.</description></item>
        /// <item><description><c>1d</c>: If the start and end dates are not passed, the cumulative usage for today is queried. If both <c>StartDate</c> and <c>EndDate</c> are passed, the specified calendar day range is queried.</description></item>
        /// <item><description><c>1w</c>: The last 7 days up to the day of the request. If the statistical results for the current day are unavailable, the results from the previous day are not used.</description></item>
        /// <item><description><c>30d</c>: The last 30 days up to the day of the request. If the statistical results for the current day are unavailable, the results from the previous day are not used.</description></item>
        /// <item><description><c>1y</c>: The statistical results for the last 365 days. If the results for the current year are unavailable, the statistical results for the previous year may be returned, and the actual coverage range may be earlier than the day of the request. This API operation does not return the statistical cutoff time for this result, so you cannot use it to confirm whether the data has been updated to the current day.</description></item>
        /// </list>
        /// <para><b>Only <c>1d</c> supports custom date ranges</b>. Do not pass start and end dates for other windows.</para>
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

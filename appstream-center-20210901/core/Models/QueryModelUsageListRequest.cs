// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryModelUsageListRequest : TeaModel {
        /// <summary>
        /// <para>The business type. This parameter is required and has no default value. The mapping between business types and values is as follows:</para>
        /// <list type="bullet">
        /// <item><description>1: Enterprise Edition.</description></item>
        /// <item><description>10: Personal Edition.</description></item>
        /// <item><description>20: Commercial Edition.</description></item>
        /// <item><description>70: Agentic Computer.</description></item>
        /// </list>
        /// <para><b>The API directly queries the model usage of the current account based on the passed BizType and does not automatically convert or replace the business type.</b> When querying the usage of the Agentic Computer business, you must explicitly pass BizType=70. Usage of different business types is counted separately.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The end date of the custom query. The format is yyyy-MM-dd. It is interpreted as a natural day in Asia/Shanghai (UTC+8) and includes the current day. This value is a date string and does not contain hours, minutes, seconds, or time zone suffixes.</para>
        /// <para><b>This parameter can be passed only when StatDateType=1d, and it must be passed or omitted together with StartDate.</b> The end date cannot be earlier than the start date. The total number of days, including the start and end dates, cannot exceed 90. When custom dates are not used, omit these two parameters directly. Do not pass empty strings or pure spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword for the model name or model code. After removing leading and trailing spaces, a case-insensitive inclusion match is performed. It is not a regular expression. If this parameter is not passed or is completely blank, no filtering by keyword is performed. If it is passed together with ModelType, both conditions take effect simultaneously.</para>
        /// <para>The translated display names of some models do not participate in name matching. To stably locate a model, we recommend that you use the returned LlmCode as the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The model display language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja-JP: Japanese.</description></item>
        /// <item><description>zh-TW: Traditional Chinese.</description></item>
        /// </list>
        /// <para>If this parameter is not passed, is blank, or has an unsupported value, zh-CN is used. It is also compatible with zh_CN, en_US, ja_JP, zh_TW, en, and ja. Case and leading or trailing spaces are ignored.</para>
        /// <para>The returned content is not guaranteed to be entirely in the selected language. Some model names and descriptions are provided in Japanese or Traditional Chinese. For other model information, brands, and capability tags, English is used when ja-JP is selected, and Simplified Chinese is used when zh-TW is selected. If the corresponding translation is missing, the existing content is retained. If the model name is missing, the model code is returned.</para>
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
        /// <item><description>LLM: Large language model.</description></item>
        /// <item><description>IMAGE: Image model.</description></item>
        /// <item><description>VIDEO: Video model.</description></item>
        /// <item><description>AUDIO: Audio model.</description></item>
        /// <item><description>EMBEDDING: Embedding model.</description></item>
        /// </list>
        /// <para>Non-empty values do not support leading or trailing spaces. Other non-empty values besides the preceding ones cause parameter validation to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The page number. It starts from 1 and the default value is 1. It must be an integer greater than or equal to 1. It is used together with PageSize for pagination. If the page number exceeds the range of the filtered results, an empty list is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of models returned per page. The default value is 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort order. If this parameter is not passed or is blank, the default value is CALL_COUNT_DESC. The value is case-sensitive, and non-empty values do not support leading or trailing spaces:</para>
        /// <list type="bullet">
        /// <item><description>CALL_COUNT_DESC: Sort by call count in descending order.</description></item>
        /// <item><description>POINTS_CONSUMPTION_DESC: Sort by consumed points in descending order.</description></item>
        /// <item><description>SUCCESS_RATE_ASC: Sort by call success rate in ascending order. Models with unavailable success rates are ranked last.</description></item>
        /// <item><description>AVG_TTFT_DESC: Sort by average time to first token latency in descending order. Models with unavailable latency are ranked last.</description></item>
        /// </list>
        /// <para>When sort values are the same, sort by model code LlmCode in ascending order. Filter and sort first, then paginate. Other non-empty values besides the preceding ones cause parameter validation to fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CALL_COUNT_DESC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The start date of the custom query. The format is yyyy-MM-dd. It is interpreted as a natural day in Asia/Shanghai (UTC+8) and includes the current day. This value is a date string and does not contain hours, minutes, seconds, or time zone suffixes.</para>
        /// <para><b>This parameter can be passed only when StatDateType=1d, and it must be passed or omitted together with EndDate.</b> The start date cannot be later than the end date. The total number of days, including the start and end dates, must be between 1 and 90. If both are omitted, the cumulative usage for today is queried. When custom dates are not used, omit these two parameters directly. Do not pass empty strings or pure spaces.</para>
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
        /// <item><description>24h: The last 24 hours up to the most recent available statistical cutoff time. The statistical cutoff time corresponds to the current hour or the previous hour.</description></item>
        /// <item><description>1d: If no start and end dates are passed, the cumulative usage for today is queried. If both StartDate and EndDate are passed, the specified natural day range is queried.</description></item>
        /// <item><description>1w: The last 7 days up to the day of the request. If the statistical results for the current day are unavailable, the results from the previous day are not used.</description></item>
        /// <item><description>30d: The last 30 days up to the day of the request. If the statistical results for the current day are unavailable, the results from the previous day are not used.</description></item>
        /// <item><description>1y: The statistical results for the last 365 days. If the results for the current year are unavailable, the statistical results for the previous year may be returned. The actual coverage range may be earlier than the day of the request. This API does not return the statistical cutoff time for this result, so you cannot use it to confirm whether the data has been updated to the current day.</description></item>
        /// </list>
        /// <para><b>Only 1d supports custom date ranges</b>. Do not pass start and end dates for other windows.</para>
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

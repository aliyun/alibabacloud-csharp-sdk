// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryBillingCostBreakdownRequest : TeaModel {
        /// <summary>
        /// <para>Optional. Filters results by API Key ID. This parameter is linked to the department and requires clientId to be specified first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>Optional. Filters results by department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The list of department IDs, separated by commas. Supports querying data for multiple departments. This parameter is mutually exclusive with client_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("clientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// <para>The query end time, in UNIX timestamp (seconds).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700086400</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The aggregation granularity. Valid values: hourly and daily.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hourly</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Optional. Filters results by member IDs, separated by commas. If not specified, the query returns data for the department and all its members. If an empty value is specified, the query returns data for the department only, excluding members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001,30002</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public string MemberUserIds { get; set; }

        /// <summary>
        /// <para>Optional. Filters results by model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>Optional. Filters results by model type. Separate multiple values with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chat</para>
        /// </summary>
        [NameInMap("modelTypes")]
        [Validation(Required=false)]
        public string ModelTypes { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query start time, in UNIX timestamp (seconds).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

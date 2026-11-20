// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryCostModelListRequest : TeaModel {
        /// <summary>
        /// <para>The API key ID used for filtering. This parameter is optional and associated with the department. You must specify clientId first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The department ID used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The department IDs. Separate multiple IDs with commas to query data for multiple departments. This parameter is mutually exclusive with clientId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("clientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// <para>The end time, specified as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700086400</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for automatic aggregation. You do not need to pass this parameter. Valid values: hourly and daily. Default value: hourly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hourly</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The maximum number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The member IDs used for filtering. Separate multiple IDs with commas. This parameter is optional. If you do not specify this parameter, the department and all its members are included. If you pass an empty value, only the department is included, excluding its members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001,30002</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public string MemberUserIds { get; set; }

        /// <summary>
        /// <para>The model IDs used for filtering. Separate multiple positive integer IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("modelIds")]
        [Validation(Required=false)]
        public string ModelIds { get; set; }

        /// <summary>
        /// <para>The model types. Separate multiple values with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM,VL</para>
        /// </summary>
        [NameInMap("modelTypes")]
        [Validation(Required=false)]
        public string ModelTypes { get; set; }

        /// <summary>
        /// <para>nextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy search by model name or code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <para>The start time, specified as a UNIX timestamp in seconds.</para>
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

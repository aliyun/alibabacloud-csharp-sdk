// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterGetBillingBillSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The API key ID used to filter results. This parameter is optional and linked to the department. You must specify clientId first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The department ID used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The list of department IDs, separated by commas. Supports querying data for multiple departments. This parameter is mutually exclusive with clientId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("clientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// <para>The end time, in UNIX timestamp format (seconds).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700086400</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The member IDs used to filter results, separated by commas. This parameter is optional. If not specified, the query returns data for the department and all its members. If an empty value is specified, the query returns data for the department only, excluding members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001,30002</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public string MemberUserIds { get; set; }

        /// <summary>
        /// <para>The model ID. This parameter is optional and used to filter by model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The model types, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chat,ChatMultimodal</para>
        /// </summary>
        [NameInMap("modelTypes")]
        [Validation(Required=false)]
        public string ModelTypes { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The start time, in UNIX timestamp format (seconds).</para>
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

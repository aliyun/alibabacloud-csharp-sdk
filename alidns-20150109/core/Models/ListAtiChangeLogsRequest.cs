// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListAtiChangeLogsRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID assigned by CNNIC after real-name authentication. The AgentID serves as the unique identifier that binds the agent to the real-name authenticated registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Justin@underarmour</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may differ for each API request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end time of the query (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1474335170000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The operation type of the Operation logs log record, such as modifying an agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2074753647748672512</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The UID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646808646232999</para>
        /// </summary>
        [NameInMap("OperatorAccount")]
        [Validation(Required=false)]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 100. Default value: 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1474335170000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>Ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ignore</para>
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}

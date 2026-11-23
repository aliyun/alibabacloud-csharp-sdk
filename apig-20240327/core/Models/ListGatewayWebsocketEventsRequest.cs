// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayWebsocketEventsRequest : TeaModel {
        /// <summary>
        /// <para>The connection identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-example</para>
        /// </summary>
        [NameInMap("connectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// <para>The end time. The value is a UNIX timestamp in seconds since the UTC epoch. Example: 1793919600.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1793919600</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of results per page for cursor-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-token-from-previous-page</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dashscope</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The log source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>access.log</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp in seconds since the UTC epoch. Example: 1793916000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1793916000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The turn identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>turn-example</para>
        /// </summary>
        [NameInMap("turnId")]
        [Validation(Required=false)]
        public string TurnId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListConnectorModelsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of a service account key. This parameter is required when multiple keys exist. You can leave this parameter empty if only one key exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ckey-xxxx</para>
        /// </summary>
        [NameInMap("connectorKeyId")]
        [Validation(Required=false)]
        public string ConnectorKeyId { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

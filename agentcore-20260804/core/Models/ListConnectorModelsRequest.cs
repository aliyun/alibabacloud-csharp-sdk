// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListConnectorModelsRequest : TeaModel {
        /// <summary>
        /// <para>The Connector Key ID. This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ckey-xxxx</para>
        /// </summary>
        [NameInMap("connectorKeyId")]
        [Validation(Required=false)]
        public string ConnectorKeyId { get; set; }

        /// <summary>
        /// <para>The page size. This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next page token. This parameter is not supported in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dGVzdA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

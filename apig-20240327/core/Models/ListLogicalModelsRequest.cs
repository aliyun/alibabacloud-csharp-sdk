// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListLogicalModelsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the gateway instance. Specifies the gateway instance whose logical models you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxxxxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The keyword used to filter logical models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chat</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Valid values: 1 to 100. This parameter is required. This operation uses token-based pagination with maxResults and nextToken, and does not use pageNumber or pageSize.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The nextToken value returned in the response of the previous page. Do not specify this parameter for the first page. The nextToken value is not returned for the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-xxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHiMarketConsumersRequest : TeaModel {
        /// <summary>
        /// <para>The developer ID. This parameter is used to filter consumers by developer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev-xxxxxxxx</para>
        /// </summary>
        [NameInMap("developerId")]
        [Validation(Required=false)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. The default value and valid values are not specified in the API definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The search keyword for the consumer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer-1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. To retrieve the next page, pass the nextToken value returned in the previous response. Do not specify this parameter for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-xxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The portal ID. This parameter is used to filter consumers by portal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>portal-xxxxxxxx</para>
        /// </summary>
        [NameInMap("portalId")]
        [Validation(Required=false)]
        public string PortalId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class QueryConsumerAuthorizationRulesRequest : TeaModel {
        /// <summary>
        /// <para>The API name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xx</para>
        /// </summary>
        [NameInMap("apiNameLike")]
        [Validation(Required=false)]
        public string ApiNameLike { get; set; }

        /// <summary>
        /// <para>The consumer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-ct21c16m1hkp64hk6qmg</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The consumer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer-xxx</para>
        /// </summary>
        [NameInMap("consumerNameLike")]
        [Validation(Required=false)]
        public string ConsumerNameLike { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cpqnr6tlhtgubc***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Specifies whether to group the results by API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("groupByApi")]
        [Validation(Required=false)]
        public bool? GroupByApi { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
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
        /// <para>The parent resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-li942gy8p01</para>
        /// </summary>
        [NameInMap("parentResourceId")]
        [Validation(Required=false)]
        public string ParentResourceId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-li942gy8p03</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApiRoute</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApiOperationsRequest : TeaModel {
        /// <summary>
        /// <para>The consumer authorization rule ID used to filter the operation list. The response includes only operations that are authorized by the specified rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-xxx</para>
        /// </summary>
        [NameInMap("consumerAuthorizationRuleId")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The authentication enablement filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is for a deployment scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forDeploy")]
        [Validation(Required=false)]
        public bool? ForDeploy { get; set; }

        /// <summary>
        /// <para>The gateway ID filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-001</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Lists operations by HTTP method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>Searches for operations by exact name match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>getUserInfo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Searches for operations by name prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GetUser</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Searches for operations by path prefix match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("pathLike")]
        [Validation(Required=false)]
        public string PathLike { get; set; }

        /// <summary>
        /// <para>The environment ID. When specified together with withConsumerInfoById, the response includes the authorization rule list of the specified consumer in the specified environment for each operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInEnvironmentId")]
        [Validation(Required=false)]
        public string WithConsumerInEnvironmentId { get; set; }

        /// <summary>
        /// <para>The consumer ID. When specified together with withConsumerInEnvironmentId, the response includes the authorization rule list of the specified consumer in the specified environment for each operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>The plugin ID used to retrieve plugin deployment information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-xxx</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}

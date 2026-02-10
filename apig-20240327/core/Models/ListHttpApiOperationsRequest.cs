// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApiOperationsRequest : TeaModel {
        /// <summary>
        /// <para>Filter the operation list based on a specific consumer authorization rule ID, and the interface list in the response only contains authorized operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-xxx</para>
        /// </summary>
        [NameInMap("consumerAuthorizationRuleId")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>Filter operations by authentication status</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>Whether to filter for deployment scenario</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forDeploy")]
        [Validation(Required=false)]
        public bool? ForDeploy { get; set; }

        /// <summary>
        /// <para>The gateway ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-001</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>List interfaces by Method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>Search operations by exact name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>getUserInfo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Search operations by name prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GetUser</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>Page number, starting from 1, default is 1 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, valid range [1, 100], default is 10 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Search operations by path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("pathLike")]
        [Validation(Required=false)]
        public string PathLike { get; set; }

        /// <summary>
        /// <para>Each operation information in the response carries a list of authorization rules for the specified consumer under the specified environment ID. The withConsumerInEnvironmentId field needs to be additionally specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInEnvironmentId")]
        [Validation(Required=false)]
        public string WithConsumerInEnvironmentId { get; set; }

        /// <summary>
        /// <para>Each operation information in the response carries a list of authorization rules for the specified consumer under the specified environment ID. The withConsumerInEnvironmentId field needs to be additionally specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>Plugin ID, use this plugin ID to retrieve the plugin release information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-xxx</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}

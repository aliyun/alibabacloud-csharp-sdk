// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApiRoutesRequest : TeaModel {
        /// <summary>
        /// <para>The backend service name. You can use this name to filter routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-svc</para>
        /// </summary>
        [NameInMap("backendServiceName")]
        [Validation(Required=false)]
        public string BackendServiceName { get; set; }

        /// <summary>
        /// <para>The ID of the consumer authorization rule used to filter the route list. The route list in the response contains only authorized routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-xxx</para>
        /// </summary>
        [NameInMap("consumerAuthorizationRuleId")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The deployment status of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotDeployed</para>
        /// </summary>
        [NameInMap("deployStatuses")]
        [Validation(Required=false)]
        public string DeployStatuses { get; set; }

        /// <summary>
        /// <para>The ID of the domain name used to filter route information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-xxx</para>
        /// </summary>
        [NameInMap("domainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

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
        /// <para>Specifies whether the query is for a deployment scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forDeploy")]
        [Validation(Required=false)]
        public bool? ForDeploy { get; set; }

        /// <summary>
        /// <para>The cloud-native API gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The route name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>itemcenter-gateway</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The route name used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. If you do not specify this parameter, the default value is 1.</para>
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
        /// <para>The route path used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("pathLike")]
        [Validation(Required=false)]
        public string PathLike { get; set; }

        /// <summary>
        /// <para>Specifies whether to include consumer authorization information in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAuthPolicyInfo")]
        [Validation(Required=false)]
        public bool? WithAuthPolicyInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the authorization rule list of the specified consumer ID in each route in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the mount information of the specified plugin ID in each route in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-xxx</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}

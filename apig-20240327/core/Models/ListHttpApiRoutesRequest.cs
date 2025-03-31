// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApiRoutesRequest : TeaModel {
        /// <summary>
        /// <para>The string that is used to filter routes based on consumer authentication rules. Only authorized APIs are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-xxx</para>
        /// </summary>
        [NameInMap("consumerAuthorizationRuleId")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The deployment state of the route.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>Deploying: The route is being deployed.</description></item>
        /// <item><description>DeployedWithChanges: The route is deployed and modified.</description></item>
        /// <item><description>Undeploying: The route is being undeployed.</description></item>
        /// <item><description>NotDeployed: The route is not deployed.</description></item>
        /// <item><description>Deployed: The route is deployed.</description></item>
        /// <item><description>UndeployFailed: The route failed to be undeployed.</description></item>
        /// <item><description>DeployFailed: The route failed to be deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotDeployed</para>
        /// </summary>
        [NameInMap("deployStatuses")]
        [Validation(Required=false)]
        public string DeployStatuses { get; set; }

        /// <summary>
        /// <para>Specifies to filter routes by domain ID.</para>
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
        /// <para>The ID of the Cloud-native API Gateway instance.</para>
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
        /// <para>The route name keyword for a fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The route path keyword for a fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("pathLike")]
        [Validation(Required=false)]
        public string PathLike { get; set; }

        /// <summary>
        /// <para>The consumer authorization information in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAuthPolicyInfo")]
        [Validation(Required=false)]
        public bool? WithAuthPolicyInfo { get; set; }

        /// <summary>
        /// <para>The authentication rules of the specified consumer in each route returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>The mounting information of the specified plug-in in each route returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-xxx</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}
